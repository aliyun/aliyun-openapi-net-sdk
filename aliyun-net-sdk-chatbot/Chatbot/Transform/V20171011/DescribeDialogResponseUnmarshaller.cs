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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class DescribeDialogResponseUnmarshaller
    {
        public static DescribeDialogResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDialogResponse describeDialogResponse = new DescribeDialogResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDialog.RequestId"),
                DialogId = context.LongValue("DescribeDialog.DialogId"),
                DialogName = context.StringValue("DescribeDialog.DialogName"),
                Description = context.StringValue("DescribeDialog.Description"),
                CreateTime = context.StringValue("DescribeDialog.CreateTime"),
                ModifyTime = context.StringValue("DescribeDialog.ModifyTime"),
                CreateUserId = context.StringValue("DescribeDialog.CreateUserId"),
                CreateUserName = context.StringValue("DescribeDialog.CreateUserName"),
                ModifyUserId = context.StringValue("DescribeDialog.ModifyUserId"),
                ModifyUserName = context.StringValue("DescribeDialog.ModifyUserName"),
                IsSampleDialog = context.BooleanValue("DescribeDialog.IsSampleDialog"),
                Status = context.IntegerValue("DescribeDialog.Status"),
                IsOnline = context.BooleanValue("DescribeDialog.IsOnline")
            };

            return describeDialogResponse;
        }
    }
}