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
	public class DescribeLogFieldsResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private List<DescribeLogFields_DataItem> data;

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

		public int? Code
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public List<DescribeLogFields_DataItem> Data
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

		public class DescribeLogFields_DataItem
		{

			private string fieldName;

			private string fieldDesc;

			private string logCode;

			private string activityName;

			private string fieldType;

			public string FieldName
			{
				get
				{
					return fieldName;
				}
				set	
				{
					fieldName = value;
				}
			}

			public string FieldDesc
			{
				get
				{
					return fieldDesc;
				}
				set	
				{
					fieldDesc = value;
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

			public string ActivityName
			{
				get
				{
					return activityName;
				}
				set	
				{
					activityName = value;
				}
			}

			public string FieldType
			{
				get
				{
					return fieldType;
				}
				set	
				{
					fieldType = value;
				}
			}
		}
	}
}
