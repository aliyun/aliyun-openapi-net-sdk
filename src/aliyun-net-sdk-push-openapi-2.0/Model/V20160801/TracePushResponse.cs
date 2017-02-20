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
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class TracePushResponse : AcsResponse
	{
	    public PushBasicInfo_ PushBasicInfo { get; set; }

	    public PushTaskInfo_ PushTaskInfo { get; set; }

	    public PushDeviceInfo_ PushDeviceInfo { get; set; }

	    public class PushBasicInfo_{
	        public long? AppId { get; set; }

	        public string Title { get; set; }

	        public string TargetType { get; set; }

	        public string PushType { get; set; }

	        public string PushTime { get; set; }

	        public string ExpireTime { get; set; }
	    }

		public class PushTaskInfo_{
		    public bool? Broadcast { get; set; }

		    public string AcceptTime { get; set; }

		    public string AndroidTaskStatus { get; set; }

		    public string IosTaskStatus { get; set; }

		    public string AndroidTaskErrCode { get; set; }

		    public string IosTaskErrCode { get; set; }

		    public List<string> DeviceSet { get; set; }
		}

		public class PushDeviceInfo_{
		    public bool? Online { get; set; }

		    public string CreateTime { get; set; }

		    public string SentTime { get; set; }

		    public string ArriveTime { get; set; }

		    public string ClickTime { get; set; }

		    public string CleanTime { get; set; }

		    public string DeviceStatus { get; set; }

		    public string DeviceErrCode { get; set; }
		}
	}
}