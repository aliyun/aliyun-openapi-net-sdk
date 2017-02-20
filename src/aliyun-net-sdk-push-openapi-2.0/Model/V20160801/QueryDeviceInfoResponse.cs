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
	public class QueryDeviceInfoResponse : AcsResponse
	{
	    public DeviceInfo_ DeviceInfo { get; set; }

	    public class DeviceInfo_{
	        public string DeviceId { get; set; }

	        public string DeviceType { get; set; }

	        public string Account { get; set; }

	        public string DeviceToken { get; set; }

	        public string Tags { get; set; }

	        public string Alias { get; set; }

	        public string LastOnlineTime { get; set; }

	        public bool? Online { get; set; }
	    }
	}
}