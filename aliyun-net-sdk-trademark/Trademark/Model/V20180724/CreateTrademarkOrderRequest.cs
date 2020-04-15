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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class CreateTrademarkOrderRequest : RpcAcsRequest<CreateTrademarkOrderResponse>
    {
        public CreateTrademarkOrderRequest()
            : base("Trademark", "2018-07-24", "CreateTrademarkOrder", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string realUserName;

		private string orderData;

		private string channel;

		private int? type;

		private string materialId;

		private long? userId;

		private string tmComment;

		private string tmNameType;

		private string tmIcon;

		private string uid;

		private string renewInfoId;

		private string rootCode;

		private string loaOssKey;

		private string registerNumber;

		private string tmName;

		private string partnerCode;

		private string phoneNum;

		private string registerName;

		private bool? isBlackIcon;

		private string bizId;

		public string RealUserName
		{
			get
			{
				return realUserName;
			}
			set	
			{
				realUserName = value;
				DictionaryUtil.Add(QueryParameters, "RealUserName", value);
			}
		}

		public string OrderData
		{
			get
			{
				return orderData;
			}
			set	
			{
				orderData = value;
				DictionaryUtil.Add(QueryParameters, "OrderData", value);
			}
		}

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public string MaterialId
		{
			get
			{
				return materialId;
			}
			set	
			{
				materialId = value;
				DictionaryUtil.Add(QueryParameters, "MaterialId", value);
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value.ToString());
			}
		}

		public string TmComment
		{
			get
			{
				return tmComment;
			}
			set	
			{
				tmComment = value;
				DictionaryUtil.Add(QueryParameters, "TmComment", value);
			}
		}

		public string TmNameType
		{
			get
			{
				return tmNameType;
			}
			set	
			{
				tmNameType = value;
				DictionaryUtil.Add(QueryParameters, "TmNameType", value);
			}
		}

		public string TmIcon
		{
			get
			{
				return tmIcon;
			}
			set	
			{
				tmIcon = value;
				DictionaryUtil.Add(QueryParameters, "TmIcon", value);
			}
		}

		public string Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value);
			}
		}

		public string RenewInfoId
		{
			get
			{
				return renewInfoId;
			}
			set	
			{
				renewInfoId = value;
				DictionaryUtil.Add(QueryParameters, "RenewInfoId", value);
			}
		}

		public string RootCode
		{
			get
			{
				return rootCode;
			}
			set	
			{
				rootCode = value;
				DictionaryUtil.Add(QueryParameters, "RootCode", value);
			}
		}

		public string LoaOssKey
		{
			get
			{
				return loaOssKey;
			}
			set	
			{
				loaOssKey = value;
				DictionaryUtil.Add(QueryParameters, "LoaOssKey", value);
			}
		}

		public string RegisterNumber
		{
			get
			{
				return registerNumber;
			}
			set	
			{
				registerNumber = value;
				DictionaryUtil.Add(QueryParameters, "RegisterNumber", value);
			}
		}

		public string TmName
		{
			get
			{
				return tmName;
			}
			set	
			{
				tmName = value;
				DictionaryUtil.Add(QueryParameters, "TmName", value);
			}
		}

		public string PartnerCode
		{
			get
			{
				return partnerCode;
			}
			set	
			{
				partnerCode = value;
				DictionaryUtil.Add(QueryParameters, "PartnerCode", value);
			}
		}

		public string PhoneNum
		{
			get
			{
				return phoneNum;
			}
			set	
			{
				phoneNum = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNum", value);
			}
		}

		public string RegisterName
		{
			get
			{
				return registerName;
			}
			set	
			{
				registerName = value;
				DictionaryUtil.Add(QueryParameters, "RegisterName", value);
			}
		}

		public bool? IsBlackIcon
		{
			get
			{
				return isBlackIcon;
			}
			set	
			{
				isBlackIcon = value;
				DictionaryUtil.Add(QueryParameters, "IsBlackIcon", value.ToString());
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

        public override CreateTrademarkOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTrademarkOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
