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

namespace Aliyun.Acs.Iot.Model.V20160530
{
	public class QueryPageByApplyIdResponse : AcsResponse
	{
	    public bool? Success { get; set; }

	    public string ErrorMessage { get; set; }

	    public int? PageSize { get; set; }

	    public int? Page { get; set; }

	    public int? PageCount { get; set; }

	    public int? Total { get; set; }

	    public List<ApplyDeviceInfo> ApplyDeviceList { get; set; }

	    public class ApplyDeviceInfo{
	        public string DeviceId { get; set; }

	        public string DeviceName { get; set; }

	        public string DeviceSecret { get; set; }
	    }
	}
}