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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot.Transform.V20160104;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20160104
{
    public class SubRequest : RpcAcsRequest<SubResponse>
    {
        public SubRequest()
            : base("Iot", "2016-01-04", "Sub")
        {
        }

		private List<string> _topics;

		private long? _appKey;

		private string _subCallback;

		private string _topicList;

		public List<string> Topics
		{
			get
			{
				return _topics;
			}

			set
			{
				_topics = value;
				for (int i = 0; i < _topics.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Topic." + (i + 1) , _topics[i]);
				}
			}
		}

		public long? AppKey
		{
			get
			{
				return _appKey;
			}
			set	
			{
				_appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string SubCallback
		{
			get
			{
				return _subCallback;
			}
			set	
			{
				_subCallback = value;
				DictionaryUtil.Add(QueryParameters, "SubCallback", value);
			}
		}

		public string TopicList
		{
			get
			{
				return _topicList;
			}
			set	
			{
				_topicList = value;
				DictionaryUtil.Add(QueryParameters, "TopicList", value);
			}
		}

        public override SubResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SubResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}