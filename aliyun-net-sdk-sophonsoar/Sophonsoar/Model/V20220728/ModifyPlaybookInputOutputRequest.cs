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
using Aliyun.Acs.sophonsoar;
using Aliyun.Acs.sophonsoar.Transform;
using Aliyun.Acs.sophonsoar.Transform.V20220728;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
    public class ModifyPlaybookInputOutputRequest : RpcAcsRequest<ModifyPlaybookInputOutputResponse>
    {
        public ModifyPlaybookInputOutputRequest()
            : base("sophonsoar", "2022-07-28", "ModifyPlaybookInputOutput")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string paramType;

		private string inputParams;

		private string outputParams;

		private string playbookUuid;

		private string exeConfig;

		private string lang;

		public string ParamType
		{
			get
			{
				return paramType;
			}
			set	
			{
				paramType = value;
				DictionaryUtil.Add(BodyParameters, "ParamType", value);
			}
		}

		public string InputParams
		{
			get
			{
				return inputParams;
			}
			set	
			{
				inputParams = value;
				DictionaryUtil.Add(BodyParameters, "InputParams", value);
			}
		}

		public string OutputParams
		{
			get
			{
				return outputParams;
			}
			set	
			{
				outputParams = value;
				DictionaryUtil.Add(BodyParameters, "OutputParams", value);
			}
		}

		public string PlaybookUuid
		{
			get
			{
				return playbookUuid;
			}
			set	
			{
				playbookUuid = value;
				DictionaryUtil.Add(BodyParameters, "PlaybookUuid", value);
			}
		}

		public string ExeConfig
		{
			get
			{
				return exeConfig;
			}
			set	
			{
				exeConfig = value;
				DictionaryUtil.Add(BodyParameters, "ExeConfig", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(BodyParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyPlaybookInputOutputResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyPlaybookInputOutputResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
