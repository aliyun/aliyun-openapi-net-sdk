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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20160104;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20160104
{
    public class UnSubRequest : RpcAcsRequest<UnSubResponse>
    {
        public UnSubRequest()
            : base("Iot", "2016-01-04", "UnSub")
        {
        }

		private List<string> topics;

		private long? appKey;

		public List<string> Topics
		{
			get
			{
				return topics;
			}

			set
			{
				topics = value;
				for (int i = 0; i < topics.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Topic." + (i + 1) , topics[i]);
				}
			}
		}

		public long? AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

        public override UnSubResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UnSubResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}