﻿#region License
/*
Copyright 2012 Rustici Software

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace RusticiSoftware.TinCanAPILibrary.Model
{
    public class Activity : StatementTarget
    {
        private const string OBJECT_TYPE = "activity";

        string id;
        ActivityDefinition definition;

        /// <summary>
        /// The activity ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// The Activity Definition
        /// </summary>
        public ActivityDefinition Definition
        {
            get { return definition; }
            set { definition = value; }
        }

        /// <summary>
        /// The object type for statement posts
        /// </summary>
        public override String ObjectType
        {
            get { return OBJECT_TYPE; }
        }
    }
}
