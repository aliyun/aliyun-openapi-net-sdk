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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class QueryInstanceNcdResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private QueryInstanceNcd_Content content;

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

		public QueryInstanceNcd_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class QueryInstanceNcd_Content
		{

			private int? ncd;

			private string instanceId1;

			private string instanceId2;

			private string instanceType;

			public int? Ncd
			{
				get
				{
					return ncd;
				}
				set	
				{
					ncd = value;
				}
			}

			public string InstanceId1
			{
				get
				{
					return instanceId1;
				}
				set	
				{
					instanceId1 = value;
				}
			}

			public string InstanceId2
			{
				get
				{
					return instanceId2;
				}
				set	
				{
					instanceId2 = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}
		}
	}
}
