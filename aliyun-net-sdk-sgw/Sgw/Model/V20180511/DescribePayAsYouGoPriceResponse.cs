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
	public class DescribePayAsYouGoPriceResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string currency;

		private float? cacheCloudEfficiencySizePrice;

		private float? gatewayClassPrice;

		private string code;

		private bool? success;

		private float? cacheCloudSSDSizePrice;

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

		[JsonProperty(PropertyName = "Currency")]
		public string Currency
		{
			get
			{
				return currency;
			}
			set	
			{
				currency = value;
			}
		}

		[JsonProperty(PropertyName = "CacheCloudEfficiencySizePrice")]
		public float? CacheCloudEfficiencySizePrice
		{
			get
			{
				return cacheCloudEfficiencySizePrice;
			}
			set	
			{
				cacheCloudEfficiencySizePrice = value;
			}
		}

		[JsonProperty(PropertyName = "GatewayClassPrice")]
		public float? GatewayClassPrice
		{
			get
			{
				return gatewayClassPrice;
			}
			set	
			{
				gatewayClassPrice = value;
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

		[JsonProperty(PropertyName = "CacheCloudSSDSizePrice")]
		public float? CacheCloudSSDSizePrice
		{
			get
			{
				return cacheCloudSSDSizePrice;
			}
			set	
			{
				cacheCloudSSDSizePrice = value;
			}
		}
	}
}
