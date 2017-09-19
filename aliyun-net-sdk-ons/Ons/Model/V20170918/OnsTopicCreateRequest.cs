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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ons.Transform;
using Aliyun.Acs.Ons.Transform.V20170918;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Model.V20170918
{
    public class OnsTopicCreateRequest : RpcAcsRequest<OnsTopicCreateResponse>
    {
        public OnsTopicCreateRequest()
            : base("Ons", "2017-09-18", "OnsTopicCreate")
        {
        }

		private long? preventCache;

		private string cluster;

		private int? queueNum;

		private string onsRegionId;

		private string onsPlatform;

		private string appName;

		private long? qps;

		private string topic;

		private string remark;

		private string appkey;

		private bool? order;

		private int? status;

		public long? PreventCache
		{
			get
			{
				return preventCache;
			}
			set	
			{
				preventCache = value;
				DictionaryUtil.Add(QueryParameters, "PreventCache", value.ToString());
			}
		}

		public string Cluster
		{
			get
			{
				return cluster;
			}
			set	
			{
				cluster = value;
				DictionaryUtil.Add(QueryParameters, "Cluster", value);
			}
		}

		public int? QueueNum
		{
			get
			{
				return queueNum;
			}
			set	
			{
				queueNum = value;
				DictionaryUtil.Add(QueryParameters, "QueueNum", value.ToString());
			}
		}

		public string OnsRegionId
		{
			get
			{
				return onsRegionId;
			}
			set	
			{
				onsRegionId = value;
				DictionaryUtil.Add(QueryParameters, "OnsRegionId", value);
			}
		}

		public string OnsPlatform
		{
			get
			{
				return onsPlatform;
			}
			set	
			{
				onsPlatform = value;
				DictionaryUtil.Add(QueryParameters, "OnsPlatform", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public long? Qps
		{
			get
			{
				return qps;
			}
			set	
			{
				qps = value;
				DictionaryUtil.Add(QueryParameters, "Qps", value.ToString());
			}
		}

		public string Topic
		{
			get
			{
				return topic;
			}
			set	
			{
				topic = value;
				DictionaryUtil.Add(QueryParameters, "Topic", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string Appkey
		{
			get
			{
				return appkey;
			}
			set	
			{
				appkey = value;
				DictionaryUtil.Add(QueryParameters, "Appkey", value);
			}
		}

		public bool? Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value.ToString());
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

        public override OnsTopicCreateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OnsTopicCreateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}