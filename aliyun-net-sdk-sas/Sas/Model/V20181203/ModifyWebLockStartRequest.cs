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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class ModifyWebLockStartRequest : RpcAcsRequest<ModifyWebLockStartResponse>
    {
        public ModifyWebLockStartRequest()
            : base("Sas", "2018-12-03", "ModifyWebLockStart", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string localBackupDir;

		private string exclusiveFile;

		private string exclusiveFileType;

		private string dir;

		private string uuid;

		private string mode;

		private string exclusiveDir;

		private string inclusiveFileType;

		private string defenceMode;

		public string LocalBackupDir
		{
			get
			{
				return localBackupDir;
			}
			set	
			{
				localBackupDir = value;
				DictionaryUtil.Add(QueryParameters, "LocalBackupDir", value);
			}
		}

		public string ExclusiveFile
		{
			get
			{
				return exclusiveFile;
			}
			set	
			{
				exclusiveFile = value;
				DictionaryUtil.Add(QueryParameters, "ExclusiveFile", value);
			}
		}

		public string ExclusiveFileType
		{
			get
			{
				return exclusiveFileType;
			}
			set	
			{
				exclusiveFileType = value;
				DictionaryUtil.Add(QueryParameters, "ExclusiveFileType", value);
			}
		}

		public string Dir
		{
			get
			{
				return dir;
			}
			set	
			{
				dir = value;
				DictionaryUtil.Add(QueryParameters, "Dir", value);
			}
		}

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
				DictionaryUtil.Add(QueryParameters, "Uuid", value);
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
			}
		}

		public string ExclusiveDir
		{
			get
			{
				return exclusiveDir;
			}
			set	
			{
				exclusiveDir = value;
				DictionaryUtil.Add(QueryParameters, "ExclusiveDir", value);
			}
		}

		public string InclusiveFileType
		{
			get
			{
				return inclusiveFileType;
			}
			set	
			{
				inclusiveFileType = value;
				DictionaryUtil.Add(QueryParameters, "InclusiveFileType", value);
			}
		}

		public string DefenceMode
		{
			get
			{
				return defenceMode;
			}
			set	
			{
				defenceMode = value;
				DictionaryUtil.Add(QueryParameters, "DefenceMode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyWebLockStartResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyWebLockStartResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
