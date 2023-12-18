import React, { useState } from "react";
import 'src/Shared/Components/Content/Pages/Settings/Settings.scss';
import ScheduleSetting from "./ScheduleSetting"; // Import the interface

interface SettingsProps {}

const Settings: React.FC<SettingsProps> = () => {
    const [settings, setSettings] = useState({
        schoolName: "Your School",
        setting1: "Option 1",
        setting2: "Option 2",
        setting3: "Option 3",
        setting4: "Option 4",
        setting5: "Option 5",
    });

    const [classScheduleSettings, setClassScheduleSettings] = useState<ScheduleSetting>({
        schoolId: "yourSchoolId", // Replace with the actual school ID
        classesPerDay: {
            Monday: 3,
            Tuesday: 4,
            Wednesday: 5,
            Thursday: 4,
            Friday: 3,
        },
        classTimes: {
            Monday: [
                { startTime: "08:00", endTime: "09:00" },
                { startTime: "10:00", endTime: "11:00" },
                { startTime: "13:00", endTime: "14:00" },
            ],
            Tuesday: [
                { startTime: "09:00", endTime: "10:00" },
                { startTime: "11:00", endTime: "12:00" },
                { startTime: "14:00", endTime: "15:00" },
                { startTime: "16:00", endTime: "17:00" },
            ],
            Wednesday: [
                { startTime: "09:00", endTime: "10:00" },
                { startTime: "10:00", endTime: "11:00" },
                { startTime: "11:00", endTime: "12:00" },
                { startTime: "12:00", endTime: "13:00" },
                { startTime: "13:00", endTime: "14:00" },
            ],
            Thursday: [
                { startTime: "09:00", endTime: "10:00" },
                { startTime: "11:00", endTime: "12:00" },
                { startTime: "14:00", endTime: "15:00" },
                { startTime: "16:00", endTime: "17:00" },
            ],
            Friday: [
                { startTime: "09:00", endTime: "10:00" },
                { startTime: "11:00", endTime: "12:00" },
                { startTime: "14:00", endTime: "15:00" },
            ],
        },
    });

    const handleClassesPerDayChange = (dayOfWeek: string, value: number) => {
        setClassScheduleSettings((prevSettings) => {
            const currentClassesCount = prevSettings.classesPerDay[dayOfWeek];
            const newClassesCount = value;
    
            // Create a copy of the current class times
            const newClassTimes = [...prevSettings.classTimes[dayOfWeek]];
    
            if (newClassesCount > currentClassesCount) {
                // If increasing, add new class times with default values
                for (let i = currentClassesCount; i < newClassesCount; i++) {
                    newClassTimes.push({ startTime: "08:00", endTime: "09:00" });
                }
            } else if (newClassesCount < currentClassesCount) {
                // If decreasing, remove extra class times
                newClassTimes.splice(newClassesCount);
            }
    
            // Return the new state directly
            return {
                ...prevSettings,
                classesPerDay: {
                    ...prevSettings.classesPerDay,
                    [dayOfWeek]: value,
                },
                classTimes: {
                    ...prevSettings.classTimes,
                    [dayOfWeek]: newClassTimes,
                },
            };
        });
    };
    
    

    const handleClassTimeChange = (dayOfWeek: string, index: number, key: string, value: string) => {
        setClassScheduleSettings((prevSettings) => {
            const newClassTimes = [...prevSettings.classTimes[dayOfWeek]];
            (newClassTimes[index] as any)[key] = value;
    
            return {
                ...prevSettings,
                classTimes: {
                    ...prevSettings.classTimes,
                    [dayOfWeek]: newClassTimes,
                },
            };
        });
    };

    const [showConfirmation, setShowConfirmation] = useState(false);
    const [confirmationAction, setConfirmationAction] = useState<string>("");

    const handleInputChange = (key: string, value: string) => {
        setSettings((prevSettings) => ({
            ...prevSettings,
            [key]: value,
        }));
    };

    const handleSave = () => {
        setConfirmationAction("Save");
        setShowConfirmation(true);
    };

    const handleSetToDefault = () => {
        setConfirmationAction("SetToDefault");
        setShowConfirmation(true);
    };

    const handleConfirmation = (confirmed: boolean) => {
        if (confirmed) {
            // Apply changes based on the confirmation action
            if (confirmationAction === "Save") {
                // Perform save logic here
                console.log("Settings saved:", settings);
            } else if (confirmationAction === "SetToDefault") {
                // Reset settings to default values
                setSettings({
                    schoolName: "Your School",
                    setting1: "Option 1",
                    setting2: "Option 2",
                    setting3: "Option 3",
                    setting4: "Option 4",
                    setting5: "Option 5",
                });
            }
        }

        // Close the confirmation window
        setShowConfirmation(false);
    };

    return (
        <div className='settings'>
            <h1>{settings.schoolName}</h1>
            <div className="class-schedule-settings">
                <h2>School Classes Schedule</h2>
                {Object.entries(classScheduleSettings.classesPerDay).map(([dayOfWeek, classesCount]) => (
                    <div key={dayOfWeek} className="classes-per-day">
                        <h3>{dayOfWeek}</h3>
                        <label>Number of Classes:</label>
                        <input
                            type="number"
                            value={classesCount}
                            onChange={(e) => handleClassesPerDayChange(dayOfWeek, parseInt(e.target.value, 10))}
                        />
                        <div className="class-times">
                            {classScheduleSettings.classTimes[dayOfWeek].map((classTime, index) => (
                                <div key={index} className="class-time">
                                    <label>Start Time:</label>
                                    <input
                                        type="time"
                                        value={classTime.startTime}
                                        onChange={(e) =>
                                            handleClassTimeChange(dayOfWeek, index, "startTime", e.target.value)
                                        }
                                    />
                                    <label>End Time:</label>
                                    <input
                                        type="time"
                                        value={classTime.endTime}
                                        onChange={(e) => handleClassTimeChange(dayOfWeek, index, "endTime", e.target.value)}
                                    />
                                </div>
                            ))}
                        </div>
                    </div>
                ))}
            </div>
            <div className="settings-list">
                <div className="setting-item">
                    <label>Setting 1:</label>
                    <input
                        type="text"
                        value={settings.setting1}
                        onChange={(e) => handleInputChange("setting1", e.target.value)}
                    />
                </div>
                <div className="setting-item">
                    <label>Setting 2:</label>
                    <select
                        value={settings.setting2}
                        onChange={(e) => handleInputChange("setting2", e.target.value)}
                    >
                        <option value="Option 1">Option 1</option>
                        <option value="Option 2">Option 2</option>
                    </select>
                </div>
                <div className="setting-item">
                    <label>Setting 3:</label>
                    <select
                        value={settings.setting3}
                        onChange={(e) => handleInputChange("setting3", e.target.value)}
                    >
                        <option value="Option 1">Option 1</option>
                        <option value="Option 2">Option 2</option>
                    </select>
                </div>
                <div className="setting-item">
                    <label>Setting 4:</label>
                    <select
                        value={settings.setting4}
                        onChange={(e) => handleInputChange("setting4", e.target.value)}
                    >
                        <option value="Option 1">Option 1</option>
                        <option value="Option 2">Option 2</option>
                    </select>
                </div>
                <div className="setting-item">
                    <label>Setting 5:</label>
                    <select
                        value={settings.setting5}
                        onChange={(e) => handleInputChange("setting5", e.target.value)}
                    >
                        <option value="Option 1">Option 1</option>
                        <option value="Option 2">Option 2</option>
                    </select>
                </div>
            </div>
            <div className="button-container">
                <button onClick={handleSave}>Save</button>
                <button onClick={handleSetToDefault}>Set to Default</button>
            </div>

            {showConfirmation && (
                <div className="confirmation-modal">
                    <p>Are you sure you want to {confirmationAction.toLowerCase()}?</p>
                    <div className="button-container">
                        <button onClick={() => handleConfirmation(true)}>Yes</button>
                        <button onClick={() => handleConfirmation(false)}>No</button>
                    </div>
                </div>
            )}
        </div>
    );
};

export default Settings;
