interface ClassScheduleSetting {
    schoolId: string;
    classesPerDay: {
        [dayOfWeek: string]: number;
    };
    classTimes: {
        [dayOfWeek: string]: {
            startTime: string;
            endTime: string;
        }[];
    };
}

export default ClassScheduleSetting;