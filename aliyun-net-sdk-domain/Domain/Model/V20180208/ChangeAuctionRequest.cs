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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180208;

namespace Aliyun.Acs.Domain.Model.V20180208
{
    public class ChangeAuctionRequest : RpcAcsRequest<ChangeAuctionResponse>
    {
        public ChangeAuctionRequest()
            : base("Domain", "2018-02-08", "ChangeAuction", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<AuctionList> auctionLists = new List<AuctionList>(){ };

		public List<AuctionList> AuctionLists
		{
			get
			{
				return auctionLists;
			}

			set
			{
				auctionLists = value;
				for (int i = 0; i < auctionLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".Winner", auctionLists[i].Winner);
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".ReserveRange", auctionLists[i].ReserveRange);
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".DomainName", auctionLists[i].DomainName);
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".EndTime", auctionLists[i].EndTime);
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".TimeLeft", auctionLists[i].TimeLeft);
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".IsReserve", auctionLists[i].IsReserve);
					for (int j = 0; j < auctionLists[i].BidRecordss.Count; j++)
					{
						DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".BidRecords." +(j + 1), auctionLists[i].BidRecordss[j]);
					}
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".WinnerPrice", auctionLists[i].WinnerPrice);
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".Status", auctionLists[i].Status);
					DictionaryUtil.Add(BodyParameters,"AuctionList." + (i + 1) + ".ReservePrice", auctionLists[i].ReservePrice);
				}
			}
		}

		public class AuctionList
		{

			private string winner;

			private string reserveRange;

			private string domainName;

			private string endTime;

			private long? timeLeft;

			private int? isReserve;

			private List<BidRecords> bidRecordss = new List<BidRecords>(){ };

			private float? winnerPrice;

			private string status;

			private float? reservePrice;

			public string Winner
			{
				get
				{
					return winner;
				}
				set	
				{
					winner = value;
				}
			}

			public string ReserveRange
			{
				get
				{
					return reserveRange;
				}
				set	
				{
					reserveRange = value;
				}
			}

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? TimeLeft
			{
				get
				{
					return timeLeft;
				}
				set	
				{
					timeLeft = value;
				}
			}

			public int? IsReserve
			{
				get
				{
					return isReserve;
				}
				set	
				{
					isReserve = value;
				}
			}

			public List<BidRecords> BidRecordss
			{
				get
				{
					return bidRecordss;
				}
				set	
				{
					bidRecordss = value;
				}
			}

			public float? WinnerPrice
			{
				get
				{
					return winnerPrice;
				}
				set	
				{
					winnerPrice = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public float? ReservePrice
			{
				get
				{
					return reservePrice;
				}
				set	
				{
					reservePrice = value;
				}
			}

			public class BidRecords
			{

				private string createTime;

				private float? price;

				private string userId;

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public float? Price
				{
					get
					{
						return price;
					}
					set	
					{
						price = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ChangeAuctionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangeAuctionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
