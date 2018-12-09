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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryDevicePropertiesDataResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private bool? nextValid;

		private long? nextTime;

		private List<QueryDevicePropertiesData_PropertyDataInfo> propertyDataInfos;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public bool? NextValid
		{
			get
			{
				return nextValid;
			}
			set	
			{
				nextValid = value;
			}
		}

		public long? NextTime
		{
			get
			{
				return nextTime;
			}
			set	
			{
				nextTime = value;
			}
		}

		public List<QueryDevicePropertiesData_PropertyDataInfo> PropertyDataInfos
		{
			get
			{
				return propertyDataInfos;
			}
			set	
			{
				propertyDataInfos = value;
			}
		}

		public class QueryDevicePropertiesData_PropertyDataInfo
		{

			private string identifier;

			private List<QueryDevicePropertiesData_PropertyInfo> list;

			public string Identifier
			{
				get
				{
					return identifier;
				}
				set	
				{
					identifier = value;
				}
			}

			public List<QueryDevicePropertiesData_PropertyInfo> List
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

			public class QueryDevicePropertiesData_PropertyInfo
			{

				private long? time;

				private string _value;

				public long? Time
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

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}