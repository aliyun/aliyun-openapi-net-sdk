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
using Aliyun.Acs.ivpd.Transform;
using Aliyun.Acs.ivpd.Transform.V20190625;

namespace Aliyun.Acs.ivpd.Model.V20190625
{
    public class CreateSegmentBodyJobRequest : RpcAcsRequest<CreateSegmentBodyJobResponse>
    {
        public CreateSegmentBodyJobRequest()
            : base("ivpd", "2019-06-25", "CreateSegmentBodyJob", "ivpd", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<DataList> dataLists = new List<DataList>(){ };

		private string jobId;

		private int? timeToLive;

		public List<DataList> DataLists
		{
			get
			{
				return dataLists;
			}

			set
			{
				dataLists = value;
				for (int i = 0; i < dataLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"DataList." + (i + 1) + ".DataId", dataLists[i].DataId);
					DictionaryUtil.Add(BodyParameters,"DataList." + (i + 1) + ".ImageUrl", dataLists[i].ImageUrl);
				}
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(BodyParameters, "JobId", value);
			}
		}

		public int? TimeToLive
		{
			get
			{
				return timeToLive;
			}
			set	
			{
				timeToLive = value;
				DictionaryUtil.Add(BodyParameters, "TimeToLive", value.ToString());
			}
		}

		public class DataList
		{

			private string dataId;

			private string imageUrl;

			public string DataId
			{
				get
				{
					return dataId;
				}
				set	
				{
					dataId = value;
				}
			}

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSegmentBodyJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSegmentBodyJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
