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
    public class BusinessCreateRequest : RpcAcsRequest<BusinessCreateResponse>
    {
        public BusinessCreateRequest()
            : base("cloudwf", "2017-03-28", "BusinessCreate", "cloudwf", "openAPI")
        {
        }

		private string businessCity;

		private string combo;

		private string warnEmail;

		private string businessManager;

		private string accessKeyId;

		private int? businessType;

		private int? warn;

		private string businessName;

		private int? businessTopType;

		private string businessAddress;

		private string businessTel;

		private string businessProvince;

		private int? businessSubtype;

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

		public string Combo
		{
			get
			{
				return combo;
			}
			set	
			{
				combo = value;
				DictionaryUtil.Add(QueryParameters, "Combo", value);
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

		public int? BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value.ToString());
			}
		}

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

		public string BusinessName
		{
			get
			{
				return businessName;
			}
			set	
			{
				businessName = value;
				DictionaryUtil.Add(QueryParameters, "BusinessName", value);
			}
		}

		public int? BusinessTopType
		{
			get
			{
				return businessTopType;
			}
			set	
			{
				businessTopType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessTopType", value.ToString());
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

		public string BusinessTel
		{
			get
			{
				return businessTel;
			}
			set	
			{
				businessTel = value;
				DictionaryUtil.Add(QueryParameters, "BusinessTel", value);
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

		public int? BusinessSubtype
		{
			get
			{
				return businessSubtype;
			}
			set	
			{
				businessSubtype = value;
				DictionaryUtil.Add(QueryParameters, "BusinessSubtype", value.ToString());
			}
		}

        public override BusinessCreateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BusinessCreateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
