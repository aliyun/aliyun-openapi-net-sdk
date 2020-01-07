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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribeAppEnvironmentDetailResponse : AcsResponse
	{

		private int? code;

		private string requestId;

		private string errMsg;

		private DescribeAppEnvironmentDetail_Result result;

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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
			}
		}

		public DescribeAppEnvironmentDetail_Result Result
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

		public class DescribeAppEnvironmentDetail_Result
		{

			private long? appId;

			private long? envId;

			private string envName;

			private int? envType;

			private string envTypeName;

			private long? appSchemaId;

			private string region;

			private int? replicas;

			public long? AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public long? EnvId
			{
				get
				{
					return envId;
				}
				set	
				{
					envId = value;
				}
			}

			public string EnvName
			{
				get
				{
					return envName;
				}
				set	
				{
					envName = value;
				}
			}

			public int? EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
				}
			}

			public string EnvTypeName
			{
				get
				{
					return envTypeName;
				}
				set	
				{
					envTypeName = value;
				}
			}

			public long? AppSchemaId
			{
				get
				{
					return appSchemaId;
				}
				set	
				{
					appSchemaId = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public int? Replicas
			{
				get
				{
					return replicas;
				}
				set	
				{
					replicas = value;
				}
			}
		}
	}
}
