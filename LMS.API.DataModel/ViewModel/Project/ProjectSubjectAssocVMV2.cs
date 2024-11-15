﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.API.DataModel.ViewModel.Project1
{
    public class ProjectSubjectAssocVMV2:BaseViewModel
    {
        public int project_subject_id { get; set; }
        public int project_id { get; set; }
        public int subject_id { get; set; }
        public string subject_name { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime modification_date { get; set; }
        public int created_by { get; set; }
        public int modified_by { get; set; }

    }
}
