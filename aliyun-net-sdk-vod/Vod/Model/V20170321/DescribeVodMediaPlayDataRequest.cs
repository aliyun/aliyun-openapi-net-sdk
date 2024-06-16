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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class DescribeVodMediaPlayDataRequest : RpcAcsRequest<DescribeVodMediaPlayDataResponse>
    {
        public DescribeVodMediaPlayDataRequest()
            : base("vod", "2017-03-21", "DescribeVodMediaPlayData", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? pageSize;

		private string playDate;

		private string os;

		private string mediaId;

		private string orderName;

		private long? pageNo;

		private string region;

		private string terminalType;

		private string orderType;

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string PlayDate
		{
			get
			{
				return playDate;
			}
			set	
			{
				playDate = value;
				DictionaryUtil.Add(QueryParameters, "PlayDate", value);
			}
		}

		public string Os
		{
			get
			{
				return os;
			}
			set	
			{
				os = value;
				DictionaryUtil.Add(QueryParameters, "Os", value);
			}
		}

		public string MediaId
		{
			get
			{
				return mediaId;
			}
			set	
			{
				mediaId = value;
				DictionaryUtil.Add(QueryParameters, "MediaId", value);
			}
		}

		public string OrderName
		{
			get
			{
				return orderName;
			}
			set	
			{
				orderName = value;
				DictionaryUtil.Add(QueryParameters, "OrderName", value);
			}
		}

		public long? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public string TerminalType
		{
			get
			{
				return terminalType;
			}
			set	
			{
				terminalType = value;
				DictionaryUtil.Add(QueryParameters, "TerminalType", value);
			}
		}

		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeVodMediaPlayDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeVodMediaPlayDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
