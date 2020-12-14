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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class ListCityMapImageDetailsRequest : RpcAcsRequest<ListCityMapImageDetailsResponse>
    {
        public ListCityMapImageDetailsRequest()
            : base("CDRS", "2020-11-01", "ListCityMapImageDetails")
        {
			Method = MethodType.POST;
        }

		private string timeInterval;

		private long? recordNumber;

		private string dataSourceId;

		public string TimeInterval
		{
			get
			{
				return timeInterval;
			}
			set	
			{
				timeInterval = value;
				DictionaryUtil.Add(BodyParameters, "TimeInterval", value);
			}
		}

		public long? RecordNumber
		{
			get
			{
				return recordNumber;
			}
			set	
			{
				recordNumber = value;
				DictionaryUtil.Add(BodyParameters, "RecordNumber", value.ToString());
			}
		}

		public string DataSourceId
		{
			get
			{
				return dataSourceId;
			}
			set	
			{
				dataSourceId = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListCityMapImageDetailsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListCityMapImageDetailsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
