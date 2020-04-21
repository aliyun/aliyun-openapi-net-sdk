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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class PreviewModelForPackageDesignResponseUnmarshaller
    {
        public static PreviewModelForPackageDesignResponse Unmarshall(UnmarshallerContext context)
        {
			PreviewModelForPackageDesignResponse previewModelForPackageDesignResponse = new PreviewModelForPackageDesignResponse();

			previewModelForPackageDesignResponse.HttpResponse = context.HttpResponse;
			previewModelForPackageDesignResponse.RequestId = context.StringValue("PreviewModelForPackageDesign.RequestId");
			previewModelForPackageDesignResponse.Code = context.StringValue("PreviewModelForPackageDesign.Code");
			previewModelForPackageDesignResponse.Message = context.StringValue("PreviewModelForPackageDesign.Message");

			PreviewModelForPackageDesignResponse.PreviewModelForPackageDesign_Data data = new PreviewModelForPackageDesignResponse.PreviewModelForPackageDesign_Data();
			data.PreviewUrl = context.StringValue("PreviewModelForPackageDesign.Data.PreviewUrl");
			previewModelForPackageDesignResponse.Data = data;
        
			return previewModelForPackageDesignResponse;
        }
    }
}
