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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeAccountConfigResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private bool? isSupportServerSideEncryption;

		private bool? isSupportClientSideEncryption;

		private string code;

		private bool? isSupportGatewayLogging;

		private bool? success;

		private bool? isSupportElasticGatewayBeta;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "IsSupportServerSideEncryption")]
		public bool? IsSupportServerSideEncryption
		{
			get
			{
				return isSupportServerSideEncryption;
			}
			set	
			{
				isSupportServerSideEncryption = value;
			}
		}

		[JsonProperty(PropertyName = "IsSupportClientSideEncryption")]
		public bool? IsSupportClientSideEncryption
		{
			get
			{
				return isSupportClientSideEncryption;
			}
			set	
			{
				isSupportClientSideEncryption = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "IsSupportGatewayLogging")]
		public bool? IsSupportGatewayLogging
		{
			get
			{
				return isSupportGatewayLogging;
			}
			set	
			{
				isSupportGatewayLogging = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "IsSupportElasticGatewayBeta")]
		public bool? IsSupportElasticGatewayBeta
		{
			get
			{
				return isSupportElasticGatewayBeta;
			}
			set	
			{
				isSupportElasticGatewayBeta = value;
			}
		}
	}
}
