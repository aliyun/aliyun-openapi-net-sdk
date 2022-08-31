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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDiagnosticReportListResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private List<DescribeDiagnosticReportList_Report> reportList;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DBInstanceId")]
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

		[JsonProperty(PropertyName = "ReportList")]
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

			private string endTime;

			private string diagnosticTime;

			private string startTime;

			private int? score;

			private string downloadURL;

			[JsonProperty(PropertyName = "EndTime")]
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

			[JsonProperty(PropertyName = "DiagnosticTime")]
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

			[JsonProperty(PropertyName = "StartTime")]
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

			[JsonProperty(PropertyName = "Score")]
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

			[JsonProperty(PropertyName = "DownloadURL")]
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
