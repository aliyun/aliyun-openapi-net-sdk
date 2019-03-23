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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class DescribeUserUsageDataExportTaskResponse : AcsResponse
    {

        private string requestId;

        private DescribeUserUsageDataExportTask_UsageDataPerPage usageDataPerPage;

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

        public DescribeUserUsageDataExportTask_UsageDataPerPage UsageDataPerPage
        {
            get
            {
                return usageDataPerPage;
            }
            set
            {
                usageDataPerPage = value;
            }
        }

        public class DescribeUserUsageDataExportTask_UsageDataPerPage
        {

            private int? totalCount;

            private int? pageSize;

            private int? pageNumber;

            private List<DescribeUserUsageDataExportTask_DataItem> data;

            public int? TotalCount
            {
                get
                {
                    return totalCount;
                }
                set
                {
                    totalCount = value;
                }
            }

            public int? PageSize
            {
                get
                {
                    return pageSize;
                }
                set
                {
                    pageSize = value;
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

            public List<DescribeUserUsageDataExportTask_DataItem> Data
            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }

            public class DescribeUserUsageDataExportTask_DataItem
            {

                private string taskName;

                private string taskId;

                private string createTime;

                private string updateTime;

                private string status;

                private string downloadUrl;

                private DescribeUserUsageDataExportTask_TaskConfig taskConfig;

                public string TaskName
                {
                    get
                    {
                        return taskName;
                    }
                    set
                    {
                        taskName = value;
                    }
                }

                public string TaskId
                {
                    get
                    {
                        return taskId;
                    }
                    set
                    {
                        taskId = value;
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

                public string UpdateTime
                {
                    get
                    {
                        return updateTime;
                    }
                    set
                    {
                        updateTime = value;
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

                public string DownloadUrl
                {
                    get
                    {
                        return downloadUrl;
                    }
                    set
                    {
                        downloadUrl = value;
                    }
                }

                public DescribeUserUsageDataExportTask_TaskConfig TaskConfig
                {
                    get
                    {
                        return taskConfig;
                    }
                    set
                    {
                        taskConfig = value;
                    }
                }

                public class DescribeUserUsageDataExportTask_TaskConfig
                {

                    private string startTime;

                    private string endTime;

                    public string StartTime
                    {
                        get
                        {
                            return startTime;
                        }
                        set
                        {
                            startTime = value;
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
                }
            }
        }
    }
}
