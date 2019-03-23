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
    public class DescribeDomainPathDataResponse : AcsResponse
    {

        private string domainName;

        private string startTime;

        private string endTime;

        private int? pageSize;

        private int? pageNumber;

        private string dataInterval;

        private int? totalCount;

        private List<DescribeDomainPathData_UsageData> pathDataPerInterval;

        public string DomainName
        {
            get
            {
                return domainName;
            }
            set
            {
                domainName = value;
            }
        }

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

        public string DataInterval
        {
            get
            {
                return dataInterval;
            }
            set
            {
                dataInterval = value;
            }
        }

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

        public List<DescribeDomainPathData_UsageData> PathDataPerInterval
        {
            get
            {
                return pathDataPerInterval;
            }
            set
            {
                pathDataPerInterval = value;
            }
        }

        public class DescribeDomainPathData_UsageData
        {

            private int? traffic;

            private int? acc;

            private string path;

            private string time;

            public int? Traffic
            {
                get
                {
                    return traffic;
                }
                set
                {
                    traffic = value;
                }
            }

            public int? Acc
            {
                get
                {
                    return acc;
                }
                set
                {
                    acc = value;
                }
            }

            public string Path
            {
                get
                {
                    return path;
                }
                set
                {
                    path = value;
                }
            }

            public string Time
            {
                get
                {
                    return time;
                }
                set
                {
                    time = value;
                }
            }
        }
    }
}
