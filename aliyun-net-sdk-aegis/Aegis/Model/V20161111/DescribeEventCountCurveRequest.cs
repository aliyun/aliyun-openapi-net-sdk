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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class DescribeEventCountCurveRequest : RpcAcsRequest<DescribeEventCountCurveResponse>
    {
        public DescribeEventCountCurveRequest()
            : base("aegis", "2016-11-11", "DescribeEventCountCurve", "vipaegis", "openAPI")
        {
        }

		private string types;

		private string sourceIp;

		private string vulEventLevels;

		private int? lastDays;

		private string healthEventLevels;

		private string suspiciousEventLevels;

		public string Types
		{
			get
			{
				return types;
			}
			set	
			{
				types = value;
				DictionaryUtil.Add(QueryParameters, "Types", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string VulEventLevels
		{
			get
			{
				return vulEventLevels;
			}
			set	
			{
				vulEventLevels = value;
				DictionaryUtil.Add(QueryParameters, "VulEventLevels", value);
			}
		}

		public int? LastDays
		{
			get
			{
				return lastDays;
			}
			set	
			{
				lastDays = value;
				DictionaryUtil.Add(QueryParameters, "LastDays", value.ToString());
			}
		}

		public string HealthEventLevels
		{
			get
			{
				return healthEventLevels;
			}
			set	
			{
				healthEventLevels = value;
				DictionaryUtil.Add(QueryParameters, "HealthEventLevels", value);
			}
		}

		public string SuspiciousEventLevels
		{
			get
			{
				return suspiciousEventLevels;
			}
			set	
			{
				suspiciousEventLevels = value;
				DictionaryUtil.Add(QueryParameters, "SuspiciousEventLevels", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeEventCountCurveResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeEventCountCurveResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
