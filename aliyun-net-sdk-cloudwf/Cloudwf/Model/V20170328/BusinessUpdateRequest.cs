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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class BusinessUpdateRequest : RpcAcsRequest<BusinessUpdateResponse>
    {
        public BusinessUpdateRequest()
            : base("cloudwf", "2017-03-28", "BusinessUpdate", "cloudwf", "openAPI")
        {
        }

		private int? warn;

		private string businessCity;

		private string warnEmail;

		private string businessAddress;

		private long? bid;

		private string businessManager;

		private string businessProvince;

		private string accessKeyId;

		public int? Warn
		{
			get
			{
				return warn;
			}
			set	
			{
				warn = value;
				DictionaryUtil.Add(QueryParameters, "Warn", value.ToString());
			}
		}

		public string BusinessCity
		{
			get
			{
				return businessCity;
			}
			set	
			{
				businessCity = value;
				DictionaryUtil.Add(QueryParameters, "BusinessCity", value);
			}
		}

		public string WarnEmail
		{
			get
			{
				return warnEmail;
			}
			set	
			{
				warnEmail = value;
				DictionaryUtil.Add(QueryParameters, "WarnEmail", value);
			}
		}

		public string BusinessAddress
		{
			get
			{
				return businessAddress;
			}
			set	
			{
				businessAddress = value;
				DictionaryUtil.Add(QueryParameters, "BusinessAddress", value);
			}
		}

		public long? Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value.ToString());
			}
		}

		public string BusinessManager
		{
			get
			{
				return businessManager;
			}
			set	
			{
				businessManager = value;
				DictionaryUtil.Add(QueryParameters, "BusinessManager", value);
			}
		}

		public string BusinessProvince
		{
			get
			{
				return businessProvince;
			}
			set	
			{
				businessProvince = value;
				DictionaryUtil.Add(QueryParameters, "BusinessProvince", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override BusinessUpdateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BusinessUpdateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
