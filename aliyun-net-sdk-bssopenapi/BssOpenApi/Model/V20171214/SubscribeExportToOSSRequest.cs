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
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class SubscribeExportToOSSRequest : RpcAcsRequest<SubscribeExportToOSSResponse>
    {
        public SubscribeExportToOSSRequest()
            : base("BssOpenApi", "2017-12-14", "SubscribeExportToOSS")
        {
        }

		private long? bucketOwnerId;

		private List<string> subscribeTypes;

		private string subscribeBucket;

		public long? BucketOwnerId
		{
			get
			{
				return bucketOwnerId;
			}
			set	
			{
				bucketOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "BucketOwnerId", value.ToString());
			}
		}

		public List<string> SubscribeTypes
		{
			get
			{
				return subscribeTypes;
			}

			set
			{
				subscribeTypes = value;
				for (int i = 0; i < subscribeTypes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SubscribeType." + (i + 1) , subscribeTypes[i]);
				}
			}
		}

		public string SubscribeBucket
		{
			get
			{
				return subscribeBucket;
			}
			set	
			{
				subscribeBucket = value;
				DictionaryUtil.Add(QueryParameters, "SubscribeBucket", value);
			}
		}

        public override SubscribeExportToOSSResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubscribeExportToOSSResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
