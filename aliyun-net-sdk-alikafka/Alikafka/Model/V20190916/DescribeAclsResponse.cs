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

namespace Aliyun.Acs.alikafka.Model.V20190916
{
	public class DescribeAclsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private List<DescribeAcls_KafkaAclVO> kafkaAclList;

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

		public List<DescribeAcls_KafkaAclVO> KafkaAclList
		{
			get
			{
				return kafkaAclList;
			}
			set	
			{
				kafkaAclList = value;
			}
		}

		public class DescribeAcls_KafkaAclVO
		{

			private string aclResourceType;

			private string host;

			private string aclOperationType;

			private string aclResourceName;

			private string aclResourcePatternType;

			private string username;

			public string AclResourceType
			{
				get
				{
					return aclResourceType;
				}
				set	
				{
					aclResourceType = value;
				}
			}

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			public string AclOperationType
			{
				get
				{
					return aclOperationType;
				}
				set	
				{
					aclOperationType = value;
				}
			}

			public string AclResourceName
			{
				get
				{
					return aclResourceName;
				}
				set	
				{
					aclResourceName = value;
				}
			}

			public string AclResourcePatternType
			{
				get
				{
					return aclResourcePatternType;
				}
				set	
				{
					aclResourcePatternType = value;
				}
			}

			public string Username
			{
				get
				{
					return username;
				}
				set	
				{
					username = value;
				}
			}
		}
	}
}
