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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class ListVccFlowInfosRequest : RpcAcsRequest<ListVccFlowInfosResponse>
    {
        public ListVccFlowInfosRequest()
            : base("eflo", "2022-05-30", "ListVccFlowInfos", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? from;

		private long? to;

		private string vccId;

		private string metricName;

		private string direction;

		public long? From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(BodyParameters, "From", value.ToString());
			}
		}

		public long? To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(BodyParameters, "To", value.ToString());
			}
		}

		public string VccId
		{
			get
			{
				return vccId;
			}
			set	
			{
				vccId = value;
				DictionaryUtil.Add(BodyParameters, "VccId", value);
			}
		}

		public string MetricName
		{
			get
			{
				return metricName;
			}
			set	
			{
				metricName = value;
				DictionaryUtil.Add(BodyParameters, "MetricName", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(BodyParameters, "Direction", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListVccFlowInfosResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListVccFlowInfosResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
