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
using Aliyun.Acs.linkedmall.Transform;
using Aliyun.Acs.linkedmall.Transform.V20180116;

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
    public class ApplyRefundRequest : RpcAcsRequest<ApplyRefundResponse>
    {
        public ApplyRefundRequest()
            : base("linkedmall", "2018-01-16", "ApplyRefund", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string bizUid;

		private int? bizClaimType;

		private long? applyReasonTextId;

		private string accountType;

		private bool? useAnonymousTbAccount;

		private List<LeavePictureList> leavePictureLists = new List<LeavePictureList>(){ };

		private int? applyRefundCount;

		private int? goodsStatus;

		private string subLmOrderId;

		private string thirdPartyUserId;

		private long? applyRefundFee;

		private string bizId;

		private string leaveMessage;

		public string BizUid
		{
			get
			{
				return bizUid;
			}
			set	
			{
				bizUid = value;
				DictionaryUtil.Add(QueryParameters, "BizUid", value);
			}
		}

		public int? BizClaimType
		{
			get
			{
				return bizClaimType;
			}
			set	
			{
				bizClaimType = value;
				DictionaryUtil.Add(QueryParameters, "BizClaimType", value.ToString());
			}
		}

		public long? ApplyReasonTextId
		{
			get
			{
				return applyReasonTextId;
			}
			set	
			{
				applyReasonTextId = value;
				DictionaryUtil.Add(QueryParameters, "ApplyReasonTextId", value.ToString());
			}
		}

		public string AccountType
		{
			get
			{
				return accountType;
			}
			set	
			{
				accountType = value;
				DictionaryUtil.Add(QueryParameters, "AccountType", value);
			}
		}

		public bool? UseAnonymousTbAccount
		{
			get
			{
				return useAnonymousTbAccount;
			}
			set	
			{
				useAnonymousTbAccount = value;
				DictionaryUtil.Add(QueryParameters, "UseAnonymousTbAccount", value.ToString());
			}
		}

		public List<LeavePictureList> LeavePictureLists
		{
			get
			{
				return leavePictureLists;
			}

			set
			{
				leavePictureLists = value;
				for (int i = 0; i < leavePictureLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"LeavePictureList." + (i + 1) + ".Picture", leavePictureLists[i].Picture);
					DictionaryUtil.Add(BodyParameters,"LeavePictureList." + (i + 1) + ".Desc", leavePictureLists[i].Desc);
				}
			}
		}

		public int? ApplyRefundCount
		{
			get
			{
				return applyRefundCount;
			}
			set	
			{
				applyRefundCount = value;
				DictionaryUtil.Add(QueryParameters, "ApplyRefundCount", value.ToString());
			}
		}

		public int? GoodsStatus
		{
			get
			{
				return goodsStatus;
			}
			set	
			{
				goodsStatus = value;
				DictionaryUtil.Add(QueryParameters, "GoodsStatus", value.ToString());
			}
		}

		public string SubLmOrderId
		{
			get
			{
				return subLmOrderId;
			}
			set	
			{
				subLmOrderId = value;
				DictionaryUtil.Add(QueryParameters, "SubLmOrderId", value);
			}
		}

		public string ThirdPartyUserId
		{
			get
			{
				return thirdPartyUserId;
			}
			set	
			{
				thirdPartyUserId = value;
				DictionaryUtil.Add(QueryParameters, "ThirdPartyUserId", value);
			}
		}

		public long? ApplyRefundFee
		{
			get
			{
				return applyRefundFee;
			}
			set	
			{
				applyRefundFee = value;
				DictionaryUtil.Add(QueryParameters, "ApplyRefundFee", value.ToString());
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

		public string LeaveMessage
		{
			get
			{
				return leaveMessage;
			}
			set	
			{
				leaveMessage = value;
				DictionaryUtil.Add(BodyParameters, "LeaveMessage", value);
			}
		}

		public class LeavePictureList
		{

			private string picture;

			private string desc;

			public string Picture
			{
				get
				{
					return picture;
				}
				set	
				{
					picture = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}
		}

        public override ApplyRefundResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplyRefundResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
