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
using Aliyun.Acs.TeslaDam.Transform;
using Aliyun.Acs.TeslaDam.Transform.V20180118;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaDam.Model.V20180118
{
    public class ActionDiskRmaRequest : RpcAcsRequest<ActionDiskRmaResponse>
    {
        public ActionDiskRmaRequest()
            : base("TeslaDam", "2018-01-18", "ActionDiskRma", "tesladam", "openAPI")
        {
        }

		private string diskName;

		private string executionId;

		private string diskSlot;

		private string hostname;

		private string diskMount;

		private string diskReason;

		private string diskSn;

		public string DiskName
		{
			get
			{
				return diskName;
			}
			set	
			{
				diskName = value;
				DictionaryUtil.Add(QueryParameters, "DiskName", value);
			}
		}

		public string ExecutionId
		{
			get
			{
				return executionId;
			}
			set	
			{
				executionId = value;
				DictionaryUtil.Add(QueryParameters, "ExecutionId", value);
			}
		}

		public string DiskSlot
		{
			get
			{
				return diskSlot;
			}
			set	
			{
				diskSlot = value;
				DictionaryUtil.Add(QueryParameters, "DiskSlot", value);
			}
		}

		public string Hostname
		{
			get
			{
				return hostname;
			}
			set	
			{
				hostname = value;
				DictionaryUtil.Add(QueryParameters, "Hostname", value);
			}
		}

		public string DiskMount
		{
			get
			{
				return diskMount;
			}
			set	
			{
				diskMount = value;
				DictionaryUtil.Add(QueryParameters, "DiskMount", value);
			}
		}

		public string DiskReason
		{
			get
			{
				return diskReason;
			}
			set	
			{
				diskReason = value;
				DictionaryUtil.Add(QueryParameters, "DiskReason", value);
			}
		}

		public string DiskSn
		{
			get
			{
				return diskSn;
			}
			set	
			{
				diskSn = value;
				DictionaryUtil.Add(QueryParameters, "DiskSn", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ActionDiskRmaResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ActionDiskRmaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}