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

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribePriceResponse : AcsResponse
    {

        private string requestId;

        private List<DescribePrice_Rule> rules;

        private DescribePrice_PriceInfo priceInfo;

        public string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = value;
            }
        }

        public List<DescribePrice_Rule> Rules
        {
            get
            {
                return rules;
            }
            set
            {
                rules = value;
            }
        }

        public DescribePrice_PriceInfo PriceInfo
        {
            get
            {
                return priceInfo;
            }
            set
            {
                priceInfo = value;
            }
        }

        public class DescribePrice_Rule
        {

            private long? ruleId;

            private string name;

            private string description;

            public long? RuleId
            {
                get
                {
                    return ruleId;
                }
                set
                {
                    ruleId = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }
        }

        public class DescribePrice_PriceInfo
        {

            private string currency;

            private float? originalPrice;

            private float? tradePrice;

            private float? discountPrice;

            private List<DescribePrice_Coupon> coupons;

            private List<string> ruleIds;

            private DescribePrice_ActivityInfo activityInfo;

            public string Currency
            {
                get
                {
                    return currency;
                }
                set
                {
                    currency = value;
                }
            }

            public float? OriginalPrice
            {
                get
                {
                    return originalPrice;
                }
                set
                {
                    originalPrice = value;
                }
            }

            public float? TradePrice
            {
                get
                {
                    return tradePrice;
                }
                set
                {
                    tradePrice = value;
                }
            }

            public float? DiscountPrice
            {
                get
                {
                    return discountPrice;
                }
                set
                {
                    discountPrice = value;
                }
            }

            public List<DescribePrice_Coupon> Coupons
            {
                get
                {
                    return coupons;
                }
                set
                {
                    coupons = value;
                }
            }

            public List<string> RuleIds
            {
                get
                {
                    return ruleIds;
                }
                set
                {
                    ruleIds = value;
                }
            }

            public DescribePrice_ActivityInfo ActivityInfo
            {
                get
                {
                    return activityInfo;
                }
                set
                {
                    activityInfo = value;
                }
            }

            public class DescribePrice_Coupon
            {

                private string couponNo;

                private string name;

                private string description;

                private string isSelected;

                public string CouponNo
                {
                    get
                    {
                        return couponNo;
                    }
                    set
                    {
                        couponNo = value;
                    }
                }

                public string Name
                {
                    get
                    {
                        return name;
                    }
                    set
                    {
                        name = value;
                    }
                }

                public string Description
                {
                    get
                    {
                        return description;
                    }
                    set
                    {
                        description = value;
                    }
                }

                public string IsSelected
                {
                    get
                    {
                        return isSelected;
                    }
                    set
                    {
                        isSelected = value;
                    }
                }
            }

            public class DescribePrice_ActivityInfo
            {

                private string checkErrMsg;

                private string errorCode;

                private string success;

                public string CheckErrMsg
                {
                    get
                    {
                        return checkErrMsg;
                    }
                    set
                    {
                        checkErrMsg = value;
                    }
                }

                public string ErrorCode
                {
                    get
                    {
                        return errorCode;
                    }
                    set
                    {
                        errorCode = value;
                    }
                }

                public string Success
                {
                    get
                    {
                        return success;
                    }
                    set
                    {
                        success = value;
                    }
                }
            }
        }
    }
}