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
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class DescribeRangeDataByLocateAndIspServiceRequest : RpcAcsRequest<DescribeRangeDataByLocateAndIspServiceResponse>
    {
        public DescribeRangeDataByLocateAndIspServiceRequest()
            : base("Cdn", "2014-11-11", "DescribeRangeDataByLocateAndIspService")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _domainNames;

		private string _locationNames;

		private string _ispNames;

		private string _startTime;

		private string _endTime;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string DomainNames
		{
			get
			{
				return _domainNames;
			}
			set	
			{
				_domainNames = value;
				DictionaryUtil.Add(QueryParameters, "DomainNames", value);
			}
		}

		public string LocationNames
		{
			get
			{
				return _locationNames;
			}
			set	
			{
				_locationNames = value;
				DictionaryUtil.Add(QueryParameters, "LocationNames", value);
			}
		}

		public string IspNames
		{
			get
			{
				return _ispNames;
			}
			set	
			{
				_ispNames = value;
				DictionaryUtil.Add(QueryParameters, "IspNames", value);
			}
		}

		public string StartTime
		{
			get
			{
				return _startTime;
			}
			set	
			{
				_startTime = value;
				DictionaryUtil.Add(QueryParameters, "startTime", value);
			}
		}

		public string EndTime
		{
			get
			{
				return _endTime;
			}
			set	
			{
				_endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

        public override DescribeRangeDataByLocateAndIspServiceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeRangeDataByLocateAndIspServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}