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
    public class RevertRpcRequest : RpcAcsRequest<RevertRpcResponse>
    {
        public RevertRpcRequest()
            : base("Push", "2015-08-27", "RevertRpc")
        {
        }

		private long? _appId;

		private string _deviceId;

		private string _rpcContent;

		private int? _timeOut;

		public long? AppId
		{
			get
			{
				return _appId;
			}
			set	
			{
				_appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value.ToString());
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

		public string RpcContent
		{
			get
			{
				return _rpcContent;
			}
			set	
			{
				_rpcContent = value;
				DictionaryUtil.Add(QueryParameters, "RpcContent", value);
			}
		}

		public int? TimeOut
		{
			get
			{
				return _timeOut;
			}
			set	
			{
				_timeOut = value;
				DictionaryUtil.Add(QueryParameters, "TimeOut", value.ToString());
			}
		}

        public override RevertRpcResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RevertRpcResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}