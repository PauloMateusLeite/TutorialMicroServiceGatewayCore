﻿using System;

namespace TutorialMicroServiceGatewayCore
{
    public class StudentAdmissionDetailsModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        public DateTime DateofJoining { get; set; }
    }
}
