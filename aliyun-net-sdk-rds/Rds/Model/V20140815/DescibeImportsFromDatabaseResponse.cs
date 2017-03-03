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
	public class DescibeImportsFromDatabaseResponse : AcsResponse
	{

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<ImportResultFromDB> items;

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

		public List<ImportResultFromDB> Items
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

		public class ImportResultFromDB{

			private int? importId;

			private ImportDataTypeEnum? importDataType;

			private ImportDataStatusEnum? importDataStatus;

			private string importDataStatusDescription;

			private string incrementalImportingTime;

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

			public ImportDataTypeEnum? ImportDataType
			{
				get
				{
					return importDataType;
				}
				set	
				{
					importDataType = value;
				}
			}

			public ImportDataStatusEnum? ImportDataStatus
			{
				get
				{
					return importDataStatus;
				}
				set	
				{
					importDataStatus = value;
				}
			}

			public string ImportDataStatusDescription
			{
				get
				{
					return importDataStatusDescription;
				}
				set	
				{
					importDataStatusDescription = value;
				}
			}

			public string IncrementalImportingTime
			{
				get
				{
					return incrementalImportingTime;
				}
				set	
				{
					incrementalImportingTime = value;
				}
			}

public enum ImportDataTypeEnum {

					Incremental,
					Full,
}

public enum ImportDataStatusEnum {

					IncrementalImporting,
					StopSyncing,
					Canceled,
					IncrementalWaiting,
					Canceling,
					Failed,
					FullImporting,
					Success,
					NotStart,
					FullExporting,
}
		}
	}
}