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
using Aliyun.Acs.Baas.Transform;
using Aliyun.Acs.Baas.Transform.V20180731;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
    public class QueryMetricRequest : RpcAcsRequest<QueryMetricResponse>
    {
        public QueryMetricRequest()
            : base("Baas", "2018-07-31", "QueryMetric")
        {
        }

		private string period;

		private string metric;

		private string port;

		private string bizid;

		private string timeArea;

		private string innerIp;

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(BodyParameters, "Period", value);
			}
		}

		public string Metric
		{
			get
			{
				return metric;
			}
			set	
			{
				metric = value;
				DictionaryUtil.Add(BodyParameters, "Metric", value);
			}
		}

		public string Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(BodyParameters, "Port", value);
			}
		}

		public string Bizid
		{
			get
			{
				return bizid;
			}
			set	
			{
				bizid = value;
				DictionaryUtil.Add(QueryParameters, "Bizid", value);
			}
		}

		public string TimeArea
		{
			get
			{
				return timeArea;
			}
			set	
			{
				timeArea = value;
				DictionaryUtil.Add(BodyParameters, "TimeArea", value);
			}
		}

		public string InnerIp
		{
			get
			{
				return innerIp;
			}
			set	
			{
				innerIp = value;
				DictionaryUtil.Add(BodyParameters, "InnerIp", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryMetricResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryMetricResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}