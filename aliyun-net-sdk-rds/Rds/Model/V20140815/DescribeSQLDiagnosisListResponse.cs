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
	public class DescribeSQLDiagnosisListResponse : AcsResponse
	{

		private List<SQLDiag> sQLDiagList;

		public List<SQLDiag> SQLDiagList
		{
			get
			{
				return sQLDiagList;
			}
			set	
			{
				sQLDiagList = value;
			}
		}

		public class SQLDiag{

			private string sQLDiagId;

			private string startTime;

			private string endTime;

			private int? status;

			private int? progress;

			public string SQLDiagId
			{
				get
				{
					return sQLDiagId;
				}
				set	
				{
					sQLDiagId = value;
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

			public int? Status
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

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}
		}
	}
}