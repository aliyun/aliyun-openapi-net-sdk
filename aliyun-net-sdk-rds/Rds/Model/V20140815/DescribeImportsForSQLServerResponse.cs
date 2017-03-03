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
	public class DescribeImportsForSQLServerResponse : AcsResponse
	{

		private int? totalRecordCounts;

		private int? pageNumber;

		private int? sQLItemsCounts;

		private List<SQLServerImport> items;

		public int? TotalRecordCounts
		{
			get
			{
				return totalRecordCounts;
			}
			set	
			{
				totalRecordCounts = value;
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

		public int? SQLItemsCounts
		{
			get
			{
				return sQLItemsCounts;
			}
			set	
			{
				sQLItemsCounts = value;
			}
		}

		public List<SQLServerImport> Items
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

		public class SQLServerImport{

			private int? importId;

			private string fileName;

			private string dBName;

			private ImportStatusEnum? importStatus;

			private string startTime;

			public int? ImportId
			{
				get
				{
					return importId;
				}
				set	
				{
					importId = value;
				}
			}

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

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

			public ImportStatusEnum? ImportStatus
			{
				get
				{
					return importStatus;
				}
				set	
				{
					importStatus = value;
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

public enum ImportStatusEnum {

					Cancelling,
					Failed,
					Cancelled,
					Success,
					Importing,
					Pending,
}
		}
	}
}