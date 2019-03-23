/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeMigrateTasksResponse : AcsResponse
    {

        private string requestId;

        private string dBInstanceId;

        private int? totalRecordCount;

        private int? pageNumber;

        private int? pageRecordCount;

        private List<DescribeMigrateTasks_MigrateTask> items;

        public string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = value;
            }
        }

        public string DBInstanceId
        {
            get
            {
                return dBInstanceId;
            }
            set
            {
                dBInstanceId = value;
            }
        }

        public int? TotalRecordCount
        {
            get
            {
                return totalRecordCount;
            }
            set
            {
                totalRecordCount = value;
            }
        }

        public int? PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
            }
        }

        public int? PageRecordCount
        {
            get
            {
                return pageRecordCount;
            }
            set
            {
                pageRecordCount = value;
            }
        }

        public List<DescribeMigrateTasks_MigrateTask> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        public class DescribeMigrateTasks_MigrateTask
        {

            private string dBName;

            private string migrateTaskId;

            private string createTime;

            private string endTime;

            private string backupMode;

            private string status;

            private string isDBReplaced;

            private string description;

            public string DBName
            {
                get
                {
                    return dBName;
                }
                set
                {
                    dBName = value;
                }
            }

            public string MigrateTaskId
            {
                get
                {
                    return migrateTaskId;
                }
                set
                {
                    migrateTaskId = value;
                }
            }

            public string CreateTime
            {
                get
                {
                    return createTime;
                }
                set
                {
                    createTime = value;
                }
            }

            public string EndTime
            {
                get
                {
                    return endTime;
                }
                set
                {
                    endTime = value;
                }
            }

            public string BackupMode
            {
                get
                {
                    return backupMode;
                }
                set
                {
                    backupMode = value;
                }
            }

            public string Status
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }

            public string IsDBReplaced
            {
                get
                {
                    return isDBReplaced;
                }
                set
                {
                    isDBReplaced = value;
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }
        }
    }
}