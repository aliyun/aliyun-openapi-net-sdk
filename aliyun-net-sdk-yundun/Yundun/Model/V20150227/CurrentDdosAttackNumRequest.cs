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
using Aliyun.Acs.Yundun.Transform;
using Aliyun.Acs.Yundun.Transform.V20150227;

namespace Aliyun.Acs.Yundun.Model.V20150227
{
    public class CurrentDdosAttackNumRequest : RpcAcsRequest<CurrentDdosAttackNumResponse>
    {
        public CurrentDdosAttackNumRequest()
            : base("Yundun", "2015-02-27", "CurrentDdosAttackNum", "yundun", "openAPI")
        {
        }

        public override CurrentDdosAttackNumResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CurrentDdosAttackNumResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
