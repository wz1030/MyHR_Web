﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MyHR_Web.Models
{
    public partial class TInterView
    {
        public TInterView()
        {
            TInterViewProcesses = new HashSet<TInterViewProcess>();
        }

        public int CInterVieweeId { get; set; }
        public string CInterVieweeGender { get; set; }
        public string CInterVieweeName { get; set; }
        public string CEmployeeEnglishName { get; set; }
        public string CPhone { get; set; }
        public string CEmail { get; set; }
        public string CAddress { get; set; }
        public string CBirthday { get; set; }
        public int CAge { get; set; }
        public byte[] CPhoto { get; set; }
        public string CEducation { get; set; }
        public string CExperience { get; set; }
        public int CJobTitle { get; set; }
        public int CDepartment { get; set; }
        public int? CInterViewerEmployeeId { get; set; }
        public string CInterViewDate { get; set; }
        public int CInterViewStatusId { get; set; }
        public int? CInterViewProcessId { get; set; }

        public virtual TUserDepartment CDepartmentNavigation { get; set; }
        public virtual TInterViewStatus CInterViewStatus { get; set; }
        public virtual TUser CInterViewerEmployee { get; set; }
        public virtual TUserJobTitle CJobTitleNavigation { get; set; }
        public virtual ICollection<TInterViewProcess> TInterViewProcesses { get; set; }
    }
}
