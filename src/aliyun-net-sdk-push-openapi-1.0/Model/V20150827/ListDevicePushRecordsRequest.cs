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
using Aliyun.Acs.Push.Transform.V20150827;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class ListDevicePushRecordsRequest : RpcAcsRequest<ListDevicePushRecordsResponse>
    {
        public ListDevicePushRecordsRequest()
            : base("Push", "2015-08-27", "ListDevicePushRecords")
        {
        }

		private long? _appKey;

		private string _deviceId;

		private int? _page;

		private int? _pageSize;

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

		public string DeviceId
		{
			get
			{
				return _deviceId;
			}
			set	
			{
				_deviceId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceId", value);
			}
		}

		public int? Page
		{
			get
			{
				return _page;
			}
			set	
			{
				_page = value;
				DictionaryUtil.Add(QueryParameters, "Page", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

        public override ListDevicePushRecordsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListDevicePushRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}