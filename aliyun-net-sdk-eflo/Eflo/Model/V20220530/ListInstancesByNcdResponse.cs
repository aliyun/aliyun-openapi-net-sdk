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
	public class ListInstancesByNcdResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListInstancesByNcd_Content content;

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

		public ListInstancesByNcd_Content Content
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

		public class ListInstancesByNcd_Content
		{

			private int? maxNcd;

			private string instanceType;

			private string sourceInstanceId;

			private List<ListInstancesByNcd_InstanceInfo> instanceInfos;

			public int? MaxNcd
			{
				get
				{
					return maxNcd;
				}
				set	
				{
					maxNcd = value;
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

			public string SourceInstanceId
			{
				get
				{
					return sourceInstanceId;
				}
				set	
				{
					sourceInstanceId = value;
				}
			}

			public List<ListInstancesByNcd_InstanceInfo> InstanceInfos
			{
				get
				{
					return instanceInfos;
				}
				set	
				{
					instanceInfos = value;
				}
			}

			public class ListInstancesByNcd_InstanceInfo
			{

				private string instanceId;

				private int? ncd;

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

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
			}
		}
	}
}
