// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

package com.microsoft.recognizers.text.datetime.german.parsers;

import com.microsoft.recognizers.text.datetime.DateTimeOptions;
import com.microsoft.recognizers.text.datetime.german.extractors.GermanDatePeriodExtractorConfiguration;
import com.microsoft.recognizers.text.datetime.german.extractors.GermanMergedExtractorConfiguration;
import com.microsoft.recognizers.text.datetime.parsers.BaseHolidayParser;
import com.microsoft.recognizers.text.datetime.parsers.BaseSetParser;
import com.microsoft.recognizers.text.datetime.parsers.IDateTimeParser;
import com.microsoft.recognizers.text.datetime.parsers.config.IMergedParserConfiguration;
import com.microsoft.recognizers.text.matcher.StringMatcher;

import java.util.regex.Pattern;

public class GermanMergedParserConfiguration extends GermanCommonDateTimeParserConfiguration implements IMergedParserConfiguration {

    public GermanMergedParserConfiguration(DateTimeOptions options) {
        super(options);

        beforeRegex = GermanMergedExtractorConfiguration.BeforeRegex;
        afterRegex = GermanMergedExtractorConfiguration.AfterRegex;
        sinceRegex = GermanMergedExtractorConfiguration.SinceRegex;
        aroundRegex = GermanMergedExtractorConfiguration.AroundRegex;
        suffixAfterRegex = GermanMergedExtractorConfiguration.SuffixAfterRegex;
        yearRegex = GermanDatePeriodExtractorConfiguration.YearRegex;
        superfluousWordMatcher = GermanMergedExtractorConfiguration.SuperfluousWordMatcher;

        getParser = new BaseSetParser(new GermanSetParserConfiguration(this));
        holidayParser = new BaseHolidayParser(new GermanHolidayParserConfiguration());
    }

    private final Pattern beforeRegex;
    private final Pattern afterRegex;
    private final Pattern sinceRegex;
    private final Pattern aroundRegex;
    private final Pattern suffixAfterRegex;
    private final Pattern yearRegex;
    private final IDateTimeParser getParser;
    private final IDateTimeParser holidayParser;
    private final StringMatcher superfluousWordMatcher;

    public Pattern getBeforeRegex() {
        return beforeRegex;
    }

    public Pattern getAfterRegex() {
        return afterRegex;
    }

    public Pattern getSinceRegex() {
        return sinceRegex;
    }

    public Pattern getAroundRegex() {
        return aroundRegex;
    }

    public Pattern getSuffixAfterRegex() {
        return suffixAfterRegex;
    }

    public Pattern getYearRegex() {
        return yearRegex;
    }

    public IDateTimeParser getGetParser() {
        return getParser;
    }

    public IDateTimeParser getHolidayParser() {
        return holidayParser;
    }

    public StringMatcher getSuperfluousWordMatcher() {
        return superfluousWordMatcher;
    }
}
