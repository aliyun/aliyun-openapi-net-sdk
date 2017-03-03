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
	public class DescribeModifyParameterLogResponse : AcsResponse
	{

		private string engine;

		private string dBInstanceId;

		private string engineVersion;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<ParameterChangeLog> items;

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
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

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
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

		public List<ParameterChangeLog> Items
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

		public class ParameterChangeLog{

			private string modifyTime;

			private string oldParameterValue;

			private string newParameterValue;

			private string parameterName;

			private StatusEnum? status;

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

			public string OldParameterValue
			{
				get
				{
					return oldParameterValue;
				}
				set	
				{
					oldParameterValue = value;
				}
			}

			public string NewParameterValue
			{
				get
				{
					return newParameterValue;
				}
				set	
				{
					newParameterValue = value;
				}
			}

			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
				}
			}

			public StatusEnum? Status
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

public enum StatusEnum {

					Applied,
					Syncing,
}
		}
	}
}