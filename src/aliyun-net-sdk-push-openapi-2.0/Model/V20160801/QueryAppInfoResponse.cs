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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryAppInfoResponse : AcsResponse
	{
	    public AppInfo_ AppInfo { get; set; }

	    public class AppInfo_{
	        public long? AppKey { get; set; }

	        public string AppId { get; set; }

	        public string PushAppId { get; set; }

	        public string AppName { get; set; }

	        public string Description { get; set; }

	        public int? IndustryId { get; set; }

	        public int? AndroidStatus { get; set; }

	        public int? IosStatus { get; set; }

	        public long? DeviceCount { get; set; }

	        public int? AppStatus { get; set; }

	        public int? Status { get; set; }

	        public Extension_ Extension { get; set; }

	        public class Extension_{
	            public string XmAppSecretKey { get; set; }

	            public string HwAppKey { get; set; }

	            public string HwAppSecretKey { get; set; }
	        }
		}
	}
}