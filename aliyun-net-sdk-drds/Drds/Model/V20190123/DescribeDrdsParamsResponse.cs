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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsParamsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeDrdsParams_ListItem> list;

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

		public List<DescribeDrdsParams_ListItem> List
		{
			get
			{
				return list;
			}
			set	
			{
				list = value;
			}
		}

		public class DescribeDrdsParams_ListItem
		{

			private string paramName;

			private string paramEnglishName;

			private string paramVariableName;

			private string paramDesc;

			private string paramValue;

			private string dbName;

			private string paramDefaultValue;

			private string paramRanges;

			private string paramLevel;

			private string paramType;

			private bool? needRestart;

			private bool? userVisible;

			public string ParamName
			{
				get
				{
					return paramName;
				}
				set	
				{
					paramName = value;
				}
			}

			public string ParamEnglishName
			{
				get
				{
					return paramEnglishName;
				}
				set	
				{
					paramEnglishName = value;
				}
			}

			public string ParamVariableName
			{
				get
				{
					return paramVariableName;
				}
				set	
				{
					paramVariableName = value;
				}
			}

			public string ParamDesc
			{
				get
				{
					return paramDesc;
				}
				set	
				{
					paramDesc = value;
				}
			}

			public string ParamValue
			{
				get
				{
					return paramValue;
				}
				set	
				{
					paramValue = value;
				}
			}

			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			public string ParamDefaultValue
			{
				get
				{
					return paramDefaultValue;
				}
				set	
				{
					paramDefaultValue = value;
				}
			}

			public string ParamRanges
			{
				get
				{
					return paramRanges;
				}
				set	
				{
					paramRanges = value;
				}
			}

			public string ParamLevel
			{
				get
				{
					return paramLevel;
				}
				set	
				{
					paramLevel = value;
				}
			}

			public string ParamType
			{
				get
				{
					return paramType;
				}
				set	
				{
					paramType = value;
				}
			}

			public bool? NeedRestart
			{
				get
				{
					return needRestart;
				}
				set	
				{
					needRestart = value;
				}
			}

			public bool? UserVisible
			{
				get
				{
					return userVisible;
				}
				set	
				{
					userVisible = value;
				}
			}
		}
	}
}
