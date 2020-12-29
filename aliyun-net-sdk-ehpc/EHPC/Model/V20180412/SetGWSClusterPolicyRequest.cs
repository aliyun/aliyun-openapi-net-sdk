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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class SetGWSClusterPolicyRequest : RpcAcsRequest<SetGWSClusterPolicyResponse>
    {
        public SetGWSClusterPolicyRequest()
            : base("EHPC", "2018-04-12", "SetGWSClusterPolicy")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string watermark;

		private string localDrive;

		private string clusterId;

		private string clipboard;

		private string usbRedirect;

		private bool? asyncMode;

		private string udpPort;

		public string Watermark
		{
			get
			{
				return watermark;
			}
			set	
			{
				watermark = value;
				DictionaryUtil.Add(QueryParameters, "Watermark", value);
			}
		}

		public string LocalDrive
		{
			get
			{
				return localDrive;
			}
			set	
			{
				localDrive = value;
				DictionaryUtil.Add(QueryParameters, "LocalDrive", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string Clipboard
		{
			get
			{
				return clipboard;
			}
			set	
			{
				clipboard = value;
				DictionaryUtil.Add(QueryParameters, "Clipboard", value);
			}
		}

		public string UsbRedirect
		{
			get
			{
				return usbRedirect;
			}
			set	
			{
				usbRedirect = value;
				DictionaryUtil.Add(QueryParameters, "UsbRedirect", value);
			}
		}

		public bool? AsyncMode
		{
			get
			{
				return asyncMode;
			}
			set	
			{
				asyncMode = value;
				DictionaryUtil.Add(QueryParameters, "AsyncMode", value.ToString());
			}
		}

		public string UdpPort
		{
			get
			{
				return udpPort;
			}
			set	
			{
				udpPort = value;
				DictionaryUtil.Add(QueryParameters, "UdpPort", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetGWSClusterPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetGWSClusterPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
