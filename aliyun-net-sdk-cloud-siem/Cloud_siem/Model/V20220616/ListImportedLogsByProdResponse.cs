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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListImportedLogsByProdResponse : AcsResponse
	{

		private string requestId;

		private List<ListImportedLogsByProd_DataItem> data;

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

		public List<ListImportedLogsByProd_DataItem> Data
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

		public class ListImportedLogsByProd_DataItem
		{

			private string prodCode;

			private string logCode;

			private string logMdsCode;

			private int? importedUserCount;

			private int? unImportedUserCount;

			private int? totalUserCount;

			private string modifyTime;

			private int? imported;

			private int? autoImported;

			private int? logType;

			private string cloudCode;

			public string ProdCode
			{
				get
				{
					return prodCode;
				}
				set	
				{
					prodCode = value;
				}
			}

			public string LogCode
			{
				get
				{
					return logCode;
				}
				set	
				{
					logCode = value;
				}
			}

			public string LogMdsCode
			{
				get
				{
					return logMdsCode;
				}
				set	
				{
					logMdsCode = value;
				}
			}

			public int? ImportedUserCount
			{
				get
				{
					return importedUserCount;
				}
				set	
				{
					importedUserCount = value;
				}
			}

			public int? UnImportedUserCount
			{
				get
				{
					return unImportedUserCount;
				}
				set	
				{
					unImportedUserCount = value;
				}
			}

			public int? TotalUserCount
			{
				get
				{
					return totalUserCount;
				}
				set	
				{
					totalUserCount = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public int? Imported
			{
				get
				{
					return imported;
				}
				set	
				{
					imported = value;
				}
			}

			public int? AutoImported
			{
				get
				{
					return autoImported;
				}
				set	
				{
					autoImported = value;
				}
			}

			public int? LogType
			{
				get
				{
					return logType;
				}
				set	
				{
					logType = value;
				}
			}

			public string CloudCode
			{
				get
				{
					return cloudCode;
				}
				set	
				{
					cloudCode = value;
				}
			}
		}
	}
}
