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
    public class CreateBlockchainApplyRequest : RpcAcsRequest<CreateBlockchainApplyResponse>
    {
        public CreateBlockchainApplyRequest()
            : base("Baas", "2018-07-31", "CreateBlockchainApply")
        {
        }

		private int? size;

		private int? machineNum;

		private int? liveTime;

		private string bizid;

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(BodyParameters, "Size", value.ToString());
			}
		}

		public int? MachineNum
		{
			get
			{
				return machineNum;
			}
			set	
			{
				machineNum = value;
				DictionaryUtil.Add(BodyParameters, "MachineNum", value.ToString());
			}
		}

		public int? LiveTime
		{
			get
			{
				return liveTime;
			}
			set	
			{
				liveTime = value;
				DictionaryUtil.Add(BodyParameters, "LiveTime", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "Bizid", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateBlockchainApplyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateBlockchainApplyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}