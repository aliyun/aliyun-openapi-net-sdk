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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class ListDataSourceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListDataSource_Data> result;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<ListDataSource_Data> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListDataSource_Data
		{

			private string gmtCreate;

			private string datasourceId;

			private string creatorId;

			private string gmtModified;

			private string parentDsType;

			private string showName;

			private string creatorName;

			private string dsType;

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string DatasourceId
			{
				get
				{
					return datasourceId;
				}
				set	
				{
					datasourceId = value;
				}
			}

			public string CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string ParentDsType
			{
				get
				{
					return parentDsType;
				}
				set	
				{
					parentDsType = value;
				}
			}

			public string ShowName
			{
				get
				{
					return showName;
				}
				set	
				{
					showName = value;
				}
			}

			public string CreatorName
			{
				get
				{
					return creatorName;
				}
				set	
				{
					creatorName = value;
				}
			}

			public string DsType
			{
				get
				{
					return dsType;
				}
				set	
				{
					dsType = value;
				}
			}
		}
	}
}
