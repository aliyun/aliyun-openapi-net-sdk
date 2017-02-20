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
	public class QueryPushDetailResponse : AcsResponse
	{
	    public long? AppKey { get; set; }

	    public string Target { get; set; }

	    public string TargetValue { get; set; }

	    public string PushType { get; set; }

	    public string DeviceType { get; set; }

	    public string Title { get; set; }

	    public string Body { get; set; }

	    public string PushTime { get; set; }

	    public string ExpireTime { get; set; }

	    public int? AntiHarassStartTime { get; set; }

	    public int? AntiHarassDuration { get; set; }

	    public bool? StoreOffline { get; set; }

	    public string BatchNumber { get; set; }

	    public string ProvinceId { get; set; }

	    public string IosApnsEnv { get; set; }

	    public bool? IosRemind { get; set; }

	    public string IosRemindBody { get; set; }

	    public int? IosBadge { get; set; }

	    public string IosMusic { get; set; }

	    public string IosSubtitle { get; set; }

	    public string IosNotificationCategory { get; set; }

	    public bool? IosMutableContent { get; set; }

	    public string IosExtParameters { get; set; }

	    public string AndroidNotifyType { get; set; }

	    public string AndroidOpenType { get; set; }

	    public string AndroidActivity { get; set; }

	    public string AndroidMusic { get; set; }

	    public string AndroidOpenUrl { get; set; }

	    public string AndroidXiaoMiActivity { get; set; }

	    public string AndroidXiaoMiNotifyTitle { get; set; }

	    public string AndroidXiaoMiNotifyBody { get; set; }

	    public int? AndroidNotificationBarType { get; set; }

	    public int? AndroidNotificationBarPriority { get; set; }

	    public string AndroidExtParameters { get; set; }
	}
}