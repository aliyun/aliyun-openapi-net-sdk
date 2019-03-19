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
    public class ShopCreateRequest : RpcAcsRequest<ShopCreateResponse>
    {
        public ShopCreateRequest()
            : base("cloudwf", "2017-03-28", "ShopCreate", "cloudwf", "openAPI")
        {
        }

		private string shopCoordinate;

		private string shopProvince;

		private int? shopTopType;

		private string shopAddress;

		private int? shopType;

		private string warnEmail;

		private string accessKeyId;

		private string shopTel;

		private string warnpHone;

		private int? warn;

		private int? shopArea;

		private string shopRemarks;

		private string shopCity;

		private int? shopSubtype;

		private string shopBrand;

		private string shopName;

		private int? shopCloseWarn;

		private long? bid;

		private string shopManager;

		private string shopBusinessHours;

		public string ShopCoordinate
		{
			get
			{
				return shopCoordinate;
			}
			set	
			{
				shopCoordinate = value;
				DictionaryUtil.Add(QueryParameters, "ShopCoordinate", value);
			}
		}

		public string ShopProvince
		{
			get
			{
				return shopProvince;
			}
			set	
			{
				shopProvince = value;
				DictionaryUtil.Add(QueryParameters, "ShopProvince", value);
			}
		}

		public int? ShopTopType
		{
			get
			{
				return shopTopType;
			}
			set	
			{
				shopTopType = value;
				DictionaryUtil.Add(QueryParameters, "ShopTopType", value.ToString());
			}
		}

		public string ShopAddress
		{
			get
			{
				return shopAddress;
			}
			set	
			{
				shopAddress = value;
				DictionaryUtil.Add(QueryParameters, "ShopAddress", value);
			}
		}

		public int? ShopType
		{
			get
			{
				return shopType;
			}
			set	
			{
				shopType = value;
				DictionaryUtil.Add(QueryParameters, "ShopType", value.ToString());
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

		public string ShopTel
		{
			get
			{
				return shopTel;
			}
			set	
			{
				shopTel = value;
				DictionaryUtil.Add(QueryParameters, "ShopTel", value);
			}
		}

		public string WarnpHone
		{
			get
			{
				return warnpHone;
			}
			set	
			{
				warnpHone = value;
				DictionaryUtil.Add(QueryParameters, "WarnpHone", value);
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

		public int? ShopArea
		{
			get
			{
				return shopArea;
			}
			set	
			{
				shopArea = value;
				DictionaryUtil.Add(QueryParameters, "ShopArea", value.ToString());
			}
		}

		public string ShopRemarks
		{
			get
			{
				return shopRemarks;
			}
			set	
			{
				shopRemarks = value;
				DictionaryUtil.Add(QueryParameters, "ShopRemarks", value);
			}
		}

		public string ShopCity
		{
			get
			{
				return shopCity;
			}
			set	
			{
				shopCity = value;
				DictionaryUtil.Add(QueryParameters, "ShopCity", value);
			}
		}

		public int? ShopSubtype
		{
			get
			{
				return shopSubtype;
			}
			set	
			{
				shopSubtype = value;
				DictionaryUtil.Add(QueryParameters, "ShopSubtype", value.ToString());
			}
		}

		public string ShopBrand
		{
			get
			{
				return shopBrand;
			}
			set	
			{
				shopBrand = value;
				DictionaryUtil.Add(QueryParameters, "ShopBrand", value);
			}
		}

		public string ShopName
		{
			get
			{
				return shopName;
			}
			set	
			{
				shopName = value;
				DictionaryUtil.Add(QueryParameters, "ShopName", value);
			}
		}

		public int? ShopCloseWarn
		{
			get
			{
				return shopCloseWarn;
			}
			set	
			{
				shopCloseWarn = value;
				DictionaryUtil.Add(QueryParameters, "ShopCloseWarn", value.ToString());
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

		public string ShopManager
		{
			get
			{
				return shopManager;
			}
			set	
			{
				shopManager = value;
				DictionaryUtil.Add(QueryParameters, "ShopManager", value);
			}
		}

		public string ShopBusinessHours
		{
			get
			{
				return shopBusinessHours;
			}
			set	
			{
				shopBusinessHours = value;
				DictionaryUtil.Add(QueryParameters, "ShopBusinessHours", value);
			}
		}

        public override ShopCreateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ShopCreateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
