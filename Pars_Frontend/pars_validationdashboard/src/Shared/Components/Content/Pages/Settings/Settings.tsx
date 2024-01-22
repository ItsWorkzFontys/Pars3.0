import React, { useState, useEffect } from "react";
import 'src/Shared/Components/Content/Pages/Settings/Settings.scss';
import ScheduleSetting from "./ScheduleSetting"; // Import the interface

interface SettingsProps {}

const Settings: React.FC<SettingsProps> = () => {
    const [settings, setSettings] = useState({
        schoolName: "Your School",
        setting1: "Class Name",
        setting2: "Option 2",
        setting3: "#000000",
        setting4: "#000000",
        setting5: "#000000",
    });

    const [classScheduleSettings, setClassScheduleSettings] = useState<ScheduleSetting>(() => {
        // Load class schedule settings from local storage when the component mounts
        const savedClassSettings = localStorage.getItem("classScheduleSettings");
        return savedClassSettings
            ? JSON.parse(savedClassSettings)
            : {
                  schoolId: "yourSchoolId", // Replace with the actual school ID
                  classesPerDay: {
                      Monday: 1,
                      Tuesday: 1,
                      Wednesday: 1,
                      Thursday: 1,
                      Friday: 1,
                  },
                  classTimes: {
                      Monday: [{ startTime: "08:00", endTime: "09:00" }],
                      Tuesday: [{ startTime: "09:00", endTime: "10:00" }],
                      Wednesday: [{ startTime: "09:00", endTime: "10:00" }],
                      Thursday: [{ startTime: "09:00", endTime: "10:00" }],
                      Friday: [{ startTime: "09:00", endTime: "10:00" }],
                  },
              };
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

    const handleClassTimeChange = (
        dayOfWeek: string,
        index: number,
        key: string,
        value: string
    ) => {
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

    const handleInputChange = (key: string, value: string | number) => {
        setSettings((prevSettings) => ({
            ...prevSettings,
            [key]: value,
        }));
    };

    const handleColorChange = (key: string, value: string) => {
        setSettings((prevSettings) => ({
            ...prevSettings,
            [key]: value,
        }));
    };

    const handleSave = () => {
        // Save class schedule settings to local storage
        localStorage.setItem(
            "classScheduleSettings",
            JSON.stringify(classScheduleSettings)
        );

        // Save general settings to local storage
        localStorage.setItem("generalSettings", JSON.stringify(settings));
        window.location.reload();
    };

    const setToDeafult = () => {
        localStorage.clear();
        window.location.reload();
    }

    useEffect(() => {
        // Save class schedule settings to local storage whenever they change
        localStorage.setItem(
            "classScheduleSettings",
            JSON.stringify(classScheduleSettings)
        );
    }, [classScheduleSettings]);

    useEffect(() => {
        // Load general settings from local storage when the component mounts
        const savedSettings = localStorage.getItem("generalSettings");

        if (savedSettings) {
            setSettings(JSON.parse(savedSettings));
        }
    }, []);

    return (
        <div className='settings'>
            <h1>{settings.schoolName} {settings.setting1}</h1>
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
                    <label>Class Name</label>
                    <input
                        type="text"
                        value={settings.setting1}
                        onChange={(e) => handleInputChange("setting1", e.target.value)}
                    />
                </div>
                <div className="setting-item">
                    <label>Number of Students:</label>
                    <input
                        type="number"
                        value={settings.setting2 as unknown as number}
                        onChange={(e) => handleInputChange("setting2", parseInt(e.target.value, 10))}
                    />
                </div>
                <div className="setting-item">
                    <label>Color for Presence:</label>
                    <input
                        type="color"
                        value={settings.setting3}
                        onChange={(e) => handleColorChange("setting3", e.target.value)}
                    />
                <div className="color-preview" style={{ backgroundColor: settings.setting3 }}>&nbsp;</div>
                </div>
                <div className="setting-item">
                    <label>Color for Absence:</label>
                    <input
                        type="color"
                        value={settings.setting4}
                        onChange={(e) => handleColorChange("setting4", e.target.value)}
                    />
                <div className="color-preview" style={{ backgroundColor: settings.setting4 }}>&nbsp;</div>
                </div>
                <div className="setting-item">
                    <label>Color for Being Late:</label>
                    <input
                        type="color"
                        value={settings.setting5}
                        onChange={(e) => handleColorChange("setting5", e.target.value)}
                    />
                <div className="color-preview" style={{ backgroundColor: settings.setting5 }}>&nbsp;</div>
                </div>
            </div>
            <div className="button-container">
                <button onClick={handleSave}>Save</button>
                {/* Removed the duplicated "handleSave" for "Set to Default" button */}
                <button onClick={setToDeafult}>Set to Default</button>
            </div>
        </div>
    );
};

export default Settings;
