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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeSubscriptionInstanceAlertResponseUnmarshaller
    {
        public static DescribeSubscriptionInstanceAlertResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSubscriptionInstanceAlertResponse describeSubscriptionInstanceAlertResponse = new DescribeSubscriptionInstanceAlertResponse();

			describeSubscriptionInstanceAlertResponse.HttpResponse = _ctx.HttpResponse;
			describeSubscriptionInstanceAlertResponse.DelayAlertPhone = _ctx.StringValue("DescribeSubscriptionInstanceAlert.DelayAlertPhone");
			describeSubscriptionInstanceAlertResponse.DelayAlertStatus = _ctx.StringValue("DescribeSubscriptionInstanceAlert.DelayAlertStatus");
			describeSubscriptionInstanceAlertResponse.DelayOverSeconds = _ctx.StringValue("DescribeSubscriptionInstanceAlert.DelayOverSeconds");
			describeSubscriptionInstanceAlertResponse.ErrCode = _ctx.StringValue("DescribeSubscriptionInstanceAlert.ErrCode");
			describeSubscriptionInstanceAlertResponse.ErrMessage = _ctx.StringValue("DescribeSubscriptionInstanceAlert.ErrMessage");
			describeSubscriptionInstanceAlertResponse.ErrorAlertPhone = _ctx.StringValue("DescribeSubscriptionInstanceAlert.ErrorAlertPhone");
			describeSubscriptionInstanceAlertResponse.ErrorAlertStatus = _ctx.StringValue("DescribeSubscriptionInstanceAlert.ErrorAlertStatus");
			describeSubscriptionInstanceAlertResponse.RequestId = _ctx.StringValue("DescribeSubscriptionInstanceAlert.RequestId");
			describeSubscriptionInstanceAlertResponse.SubscriptionInstanceID = _ctx.StringValue("DescribeSubscriptionInstanceAlert.SubscriptionInstanceID");
			describeSubscriptionInstanceAlertResponse.SubscriptionInstanceName = _ctx.StringValue("DescribeSubscriptionInstanceAlert.SubscriptionInstanceName");
			describeSubscriptionInstanceAlertResponse.Success = _ctx.StringValue("DescribeSubscriptionInstanceAlert.Success");
        
			return describeSubscriptionInstanceAlertResponse;
        }
    }
}
