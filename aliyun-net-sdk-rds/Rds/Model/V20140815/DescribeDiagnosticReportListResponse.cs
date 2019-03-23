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
    public class DescribeDiagnosticReportListResponse : AcsResponse
    {

        private string requestId;

        private List<DescribeDiagnosticReportList_Report> reportList;

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

        public List<DescribeDiagnosticReportList_Report> ReportList
        {
            get
            {
                return reportList;
            }
            set
            {
                reportList = value;
            }
        }

        public class DescribeDiagnosticReportList_Report
        {

            private string diagnosticTime;

            private int? score;

            private string startTime;

            private string endTime;

            private string downloadURL;

            public string DiagnosticTime
            {
                get
                {
                    return diagnosticTime;
                }
                set
                {
                    diagnosticTime = value;
                }
            }

            public int? Score
            {
                get
                {
                    return score;
                }
                set
                {
                    score = value;
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

            public string DownloadURL
            {
                get
                {
                    return downloadURL;
                }
                set
                {
                    downloadURL = value;
                }
            }
        }
    }
}