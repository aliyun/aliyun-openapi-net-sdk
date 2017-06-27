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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dysmsapi.Model.V20170525
{
    public class QuerySendDetailsResponse : AcsResponse
    {
        public virtual String Code { get; set; }

        public virtual String Message { get; set; }

        public virtual int? TotalCount { get; set; }

        public virtual int? TotalPage { get; set; }

        public List<SmsSendDetailDTO> SmsSendDetailDTOs { get; set; }
    }

    public class SmsSendDetailDTO
    {
        public String PhoneNum { get; set; }

        public long? SendStatus { get; set; }

        public String ErrCode { get; set; }

        public String TemplateCode { get; set; }

        public String Content { get; set; }

        public String SendDate { get; set; }

        public String ReceiveDate { get; set; }

        public String OutId { get; set; }

    }
}
