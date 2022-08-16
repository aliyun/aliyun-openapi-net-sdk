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
using Aliyun.Acs.Ft.Model.V20180713;

namespace Aliyun.Acs.Ft.Transform.V20180713
{
    public class FtGatedLaunchPolicy4ResponseUnmarshaller
    {
        public static FtGatedLaunchPolicy4Response Unmarshall(UnmarshallerContext _ctx)
        {
			FtGatedLaunchPolicy4Response ftGatedLaunchPolicy4Response = new FtGatedLaunchPolicy4Response();

			ftGatedLaunchPolicy4Response.HttpResponse = _ctx.HttpResponse;
			ftGatedLaunchPolicy4Response.RequestId = _ctx.StringValue("FtGatedLaunchPolicy4.RequestId");
			ftGatedLaunchPolicy4Response.IsGatedLaunch = _ctx.StringValue("FtGatedLaunchPolicy4.IsGatedLaunch");
        
			return ftGatedLaunchPolicy4Response;
        }
    }
}
